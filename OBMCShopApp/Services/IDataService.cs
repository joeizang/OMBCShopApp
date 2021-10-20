using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Specification;
using OBMCShopApp.Models;
using Syncfusion.EJ2.Navigations;

namespace OBMCShopApp.Services
{
    public interface IDataService<T> where T : BaseDomainModel
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<T> GetOne(int id);
        Task<T> GetOne(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAll(ISpecification<T> spec);
        void CreateOne(T one);
        void UpdateOne(T one);
        void DeleteOne(T one);

        Task Commit();
    }
}