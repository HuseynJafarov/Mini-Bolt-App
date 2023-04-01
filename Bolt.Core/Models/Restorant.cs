using Bolt.Core.Base;
using Bolt.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Core.Models
{
    public class Restorant:BaseEntity
    {
        public int Name { get; set; }
        public RestorantCategory RestoranEnum { get; set; }
        public List<Product> ProductList { get; set; }

    }
}
