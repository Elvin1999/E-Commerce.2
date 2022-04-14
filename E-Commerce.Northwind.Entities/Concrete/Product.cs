using E_Commerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Entities.Concrete
{
    public class Product :IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
