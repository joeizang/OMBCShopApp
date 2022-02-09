using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Data;
using OBMCShopApp.Models;
using OBMCShopApp.Notifications.ProductsNotifications;
using OBMCShopApp.QuerySpecifications;
using OBMCShopApp.Services;
using OBMCShopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OBMCShopApp.Controllers
{
    //[Authorize(Roles = "Owner,Admin")]
    public class ProductsController : Controller
    {
        private readonly OBMCShopAppContext _context;
        private readonly IProductDataService _service;
        private readonly IShelfDataService _dataAccess;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProductsController(IProductDataService service,
            IShelfDataService shelfDataService,
            OBMCShopAppContext context,
            IMapper mapper,
            IMediator mediator)
        {
            _context = context;
            _service = service;
            _dataAccess = shelfDataService;
            _mapper = mapper;
            _mediator = mediator;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllProducts().ConfigureAwait(false);
            return View(result);
        }

        [Route("api/products")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(typeof(List<ProductIndexViewModel>))]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _service.GetAllProducts().ConfigureAwait(false);
            return Ok(result);
        }

        [Route("api/all-products")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(typeof(List<ProductSoldViewModel>))]
        public async Task<IActionResult> GetProjectedProducts()
        {
            var products = await _context.Products.AsNoTracking()
                .Select(x => new ProductSoldViewModel
                {
                    Name = x.Name,
                    ProductID = x.Id,
                    Quantity = x.Quantity,
                    RetailPrice = x.RetailPrice
                }).ToListAsync().ConfigureAwait(false);
            return Ok(products);
        }

        public async Task<ActionResult> Create()
        {
            var shelves = await _dataAccess.GetShelfNumbers().ConfigureAwait(false);
            var input = new ProductCreateInputModel
            {
                Shelves = shelves
            };
            return View(input);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProductCreateInputModel model)
        {
            var duplicateCheck = await _service.GetOne(new FindProductByNameSpec(model.Name)).ConfigureAwait(false);
            if (!ModelState.IsValid || duplicateCheck is not null)
            {
                ModelState.AddModelError(
                    "Error", "Your submission has errors or You are trying to create a Product that exists already!");
                return View();
            }
            try
            {
                var product = _service.CreateProduct(model, _service);
                await _service.Commit().ConfigureAwait(false);
                await _mediator.Publish(new ProductAdded
                {
                    Product = product,
                    AddedBy = HttpContext.User?.Identity?.Name,
                    AddedWhen = DateOnly.FromDateTime(DateTime.Now)
                }, CancellationToken.None)
                    .ConfigureAwait(false);
                return View("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Server Exception", e.Message);
                return View(model);
            }
        }

        [HttpGet("products/update-product/{id:int}")]
        public async Task<ActionResult> UpdateProduct(int id)
        {
            var getProduct = await _service.GetOne(id).ConfigureAwait(false);
            var shelves = await _dataAccess.GetShelfNumbers()
                .ConfigureAwait(false);
            if (getProduct is null)
                return NotFound();
            var viewModel = _mapper.Map<ProductUpdateViewModel>(getProduct);
            viewModel.Shelves = shelves;
            return View("Edit", viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateProduct(int productId, ProductUpdateViewModel model)
        {
            var targetProduct = await _service.GetOne(productId).ConfigureAwait(false);
            if (targetProduct is null)
            {
                ModelState.AddModelError("Update Error", $"The id {productId} does not belong to a real product!");
                return View("Edit", model);
            }
            try
            {
                var product = _service.UpdateProduct(targetProduct, model, _service);
                await _service.Commit().ConfigureAwait(false);
                await _mediator.Publish(new ProductUpdated
                {
                    Product = product,
                    UpdatedAt = product.UpdatedAt,
                    UpdatedBy = product.UpdatedBy
                }).ConfigureAwait(false);
                return View("Edit");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", $"There was an error {e.Message}");
                return View("Edit");
            }
        }

        [HttpDelete("{productId:int}")]
        public async Task<ActionResult> DeleteProduct(int productId)
        {
            if (productId is int.MaxValue || productId is int.MinValue)
                return BadRequest(new { Error = "The ID of product is invalid" });
            try
            {
                _service.DeleteOne(new Product { Id = productId });
                await _service.Commit().ConfigureAwait(false);
                await _mediator.Publish(new ProductDeleted
                {
                    ProductId = productId,
                    DeletedAt = DateOnly.FromDateTime(DateTime.Now)
                }).ConfigureAwait(false);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ModelState.AddModelError("DeleteError", $"There was an error. {e.Message}");
                return BadRequest(ModelState);
            }
        }

    }
}