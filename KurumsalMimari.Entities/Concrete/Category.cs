using KurumsalMimari.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurumsalMimari.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategorytId { get; set; }
        public string CategoryName { get; set; }
    }
}
