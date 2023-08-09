using E_Commerce_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_App.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category Get(int id);

        void Update(Category obj);
        void Save();
    }
}
