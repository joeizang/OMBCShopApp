using System;
using Ardalis.Specification;

namespace OBMCShopApp.QuerySpecifications.Product
{
    public class FindProductByNameSpec: Specification<Models.Product>, ISingleResultSpecification<Models.Product>
    {
        public FindProductByNameSpec(string productName)
        {
            Query.AsNoTracking().Where(p => p.Name == productName || p.Name.Contains(productName));
        }
    }

    public class FindProductByPrice : Specification<Models.Product>, ISingleResultSpecification<Models.Product>
    {
        public FindProductByPrice(decimal price)
        {
            Query.AsNoTracking().Where(p => p.CostPrice == price || p.RetailPrice == price);
        }
    }

    public class FindProductByShelfNumber : Specification<Models.Product>, ISingleResultSpecification<Models.Product>
    {
        public FindProductByShelfNumber(int shelfNumber)
        {
            Query.AsNoTracking().Include(p => p.ProductShelf)
                .Where(p => p.ShelfId == shelfNumber);
        }
    }

    public class FindProductBySupplyDate : Specification<Models.Product>, ISingleResultSpecification<Models.Product>
    {
        public FindProductBySupplyDate(DateTime date)
        {
            Query.AsNoTracking().Where(p => p.SupplyDate == date);
        }
    }
    
    
}