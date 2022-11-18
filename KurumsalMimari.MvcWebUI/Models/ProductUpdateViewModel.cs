using KurumsalMimari.Entities.Concrete;
using System.Collections.Generic;

namespace KurumsalMimari.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; internal set; }
        public List<Category> Categories { get; internal set; }
    }
}
