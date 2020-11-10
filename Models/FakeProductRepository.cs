using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Eyeliner", Price = 25 },
            new Product { Name = "Nude Palette", Price = 179 },
            new Product { Name = "Facial Cleanser", Price = 95 }
        };

    }
}
