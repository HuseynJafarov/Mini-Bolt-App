using Bolt.Core.Base;
using Bolt.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Core.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public ProductCategory ProductEnum { get; set; }
        public Restorant Restorant { get; set; }

        public Product(ProductCategory category)
        {
            ProductEnum = category;
        }

        public override string ToString()
        {
            return $"ProductName{ProductName} Price{Price} RestoranName{Restorant.Name}";
        }

    }
}
