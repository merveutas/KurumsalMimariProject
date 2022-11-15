using KurumsalMimari.Business.Abstract;
using KurumsalMimari.DataAccess.Abstract;
using KurumsalMimari.DataAccess.Concrete.EntityFramework;
using KurumsalMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari.Business.Concrete
{
    public class CategoryManager : ICategorytService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
