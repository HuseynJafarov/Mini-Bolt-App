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
        public string Name { get; set; }
        public RestorantCategory RestoranEnum { get; set; }
        public List<Product> ProductList;
        public Product Product { get; set; }
        
        public Restorant(RestorantCategory category)
        {
            ProductList = new List<Product>();
            RestoranEnum = category;
           
        }

        public override string ToString()
        {
            return $"Id: {Id} RestoranName:{Name} Category:{RestoranEnum}";
        }

    }
}
