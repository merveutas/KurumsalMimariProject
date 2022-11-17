using System;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
