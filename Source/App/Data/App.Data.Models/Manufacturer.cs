using App.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Models
{
    public class Manufacturer : BaseModel<int>
    {
        public Manufacturer()
        {
            this.Categories = new HashSet<Category>();
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public virtual ICollection<Category> Categories{ get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
