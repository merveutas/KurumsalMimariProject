using KurumsalMimari.Entities.Concrete;
using System.Collections.Generic;

namespace KurumsalMimari.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}
