using System;
using Ardalis.Specification;

namespace OBMCShopApp.QuerySpecifications
{
    public class FindSaleByDate : Specification<Models.Sale>, ISingleResultSpecification<Models.Sale>
    {
        public FindSaleByDate(DateTimeOffset saleDate)
        {
            Query.AsNoTracking().Include(s => s.ItemsSold)
                .Where(s => s.SaleDate == saleDate);
        }
    }

    public class FindSaleByAmountSpent : Specification<Models.Sale>
    {
        public FindSaleByAmountSpent(decimal amount)
        {
            Query.AsNoTracking().Include(s => s.ItemsSold)
                .Where(s => s.GrandTotal == amount);
        }
    }

    public class FindSaleByAmountSpentUpperBound : Specification<Models.Sale>
    {
        public FindSaleByAmountSpentUpperBound(decimal amount)
        {
            Query.AsNoTracking().Include(s => s.ItemsSold)
                .Where(s => s.GrandTotal >= amount || s.SubTotal >= amount);
        }
    }
}