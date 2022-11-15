using KurumsalMimari.Entities.Concrete;
using System.Collections.Generic;

namespace KurumsalMimari.Business.Abstract
{
    public interface ICategorytService
    {
        List<Category> GetAll();
    }
}
