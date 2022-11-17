using KurumsalMimari.Entities.Concrete;
using System.Collections.Generic;

namespace KurumsalMimari.MvcWebUI.Models
{
    public class ProductListVieModel
    {
        public List<Product> Products { get; internal set; }
        public int PageSize { get; internal set; }
        public int PageCount { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
