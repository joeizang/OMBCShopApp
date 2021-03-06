using Ardalis.Specification;
using OBMCShopApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBMCShopApp.Services
{
    public interface IDataService<T> where T : BaseDomainModel
    {
        Task<List<T>> GetAll();
        Task<T> GetOne(int id);
        Task<T> GetOne(ISpecification<T> spec);
        Task<List<T>> GetAll(ISpecification<T> spec);
        void CreateOne(T one);
        void UpdateOne(T one);
        void DeleteOne(T one);

        Task Commit();
    }
}