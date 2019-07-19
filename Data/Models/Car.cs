using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public int available { get; set; }
        public int categoryId { get; set; }
        public virtual Categoty Categoty { get; set; }

    }
}
