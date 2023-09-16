using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercizio5
{
    public class Product
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Product() { }
        public Product(int id, string photo, string name, double price, string description) {
            Id = id;
            Photo = photo;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}