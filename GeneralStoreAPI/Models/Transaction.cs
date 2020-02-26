﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey(nameof(Product))]  // [ForeignKey("Product")] Connects Transaction Class to Product Class
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }




        [ForeignKey(nameof(Customer))]  //this object (customer) is a foreign key, connects Transaction Class to Customer Class
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }



        public DateTime DateOfTransaction { get; set; }
        public decimal TotalCost => Product.Price * ProductCount;
        public int ProductCount { get; set; }
    }
}