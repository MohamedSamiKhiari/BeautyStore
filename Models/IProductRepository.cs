using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeautyStore.Models;

namespace BeautyStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
