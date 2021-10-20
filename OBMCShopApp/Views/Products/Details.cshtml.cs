using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Data;
using OBMCShopApp.Models;

namespace OBMCShopApp.Views.Products
{
    public class DetailsModel : PageModel
    {
        private readonly OBMCShopApp.Data.OBMCShopAppContext _context;

        public DetailsModel(OBMCShopApp.Data.OBMCShopAppContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products
                .Include(p => p.ProductShelf).FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
