﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
    }
}
