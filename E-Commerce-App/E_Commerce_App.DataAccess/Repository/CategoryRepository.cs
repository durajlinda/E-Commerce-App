using System.Linq;
using E_Commerce_App.DataAccess.Data;
using E_Commerce_App.DataAccess.Repository.IRepository;
using E_Commerce_App.Models;

namespace E_Commerce_App.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }


        public Category Get(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);
        }

    }
}
