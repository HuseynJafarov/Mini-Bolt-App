  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Core.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
