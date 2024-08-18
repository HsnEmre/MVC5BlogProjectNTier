using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager
    {
        Repository<Categories> _repositoryCategory = new Repository<Categories>();
        public List<Categories> GetAll()
        {
            return _repositoryCategory.List();
        }

        public int CategoryAddBBL(Categories p)
        {
            if (p.CategoryName == null
                || p.CategoryDescription == null
                || p.CategoryName.Length <= 4
                || p.CategoryDescription.Length <= 30)
            {
                return -1;
            }
            return _repositoryCategory.Insert(p);
        }

        public Categories FindCategory(int id)
        {
            return _repositoryCategory.Find(x => x.CategoryID == id);
        }


        public int EditCategory(Categories p)
        {
            Categories category = _repositoryCategory.Find(x => x.CategoryID == p.CategoryID);
            if (p.CategoryName==""|p.CategoryName.Length<=4|p.CategoryName.Length>=30)
            {
                return -1;
            }
            

            category.CategoryName = p.CategoryName;
            category.CategoryDescription = p.CategoryDescription;
            return _repositoryCategory.Update(category);
            
        }

        public int DeleteCategoryBL(int id)
        {
            Categories category=_repositoryCategory.Find(x=>x.CategoryID==id);

            category.CategoryStatus = false;
            return _repositoryCategory.Update(category);
        }

        public int DeleteStatusTrueBL(int id)
        {
            Categories category = _repositoryCategory.Find(x => x.CategoryID == id);

            category.CategoryStatus = true;
            return _repositoryCategory.Update(category);
        }


    }
}
