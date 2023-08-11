using E_Commerce_App.Models;

namespace E_Commerce_App.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product Get(int id);

        void Update(Product obj);
        void Save();
    }
}
