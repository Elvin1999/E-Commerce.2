﻿using E_Commerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
