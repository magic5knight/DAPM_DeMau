using System;

namespace DeMau.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int Quantity { get; set; }
        public string BookImage { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}