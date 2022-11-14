using KurumsalMimari.Core.DataAccess;
using KurumsalMimari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
