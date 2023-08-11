using System.Linq;
using E_Commerce_App.DataAccess.Data;
using E_Commerce_App.DataAccess.Repository.IRepository;
using E_Commerce_App.Models;

namespace E_Commerce_App.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }

        public Product Get(int id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
