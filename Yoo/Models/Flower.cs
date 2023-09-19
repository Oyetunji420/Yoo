﻿namespace Yoo.Models
{
    public class Flower
    {
      public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
