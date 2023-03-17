using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Infrastructure.Event.Product
{
    public class ProductCreated
    {

        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
