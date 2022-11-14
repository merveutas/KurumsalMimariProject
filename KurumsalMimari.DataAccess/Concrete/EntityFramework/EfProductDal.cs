using KurumsalMimari.Core.DataAccess.EntityFramework;
using KurumsalMimari.DataAccess.Abstract;
using KurumsalMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NortwindContext>,IProductDal
    {
    }

 
}
