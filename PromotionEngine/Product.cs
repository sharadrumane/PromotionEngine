using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class Product
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public int Value { get; set; }
        
        public Product(string id, int value)
        {
            this.Id = id;
            this.Value = value;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 15m;
                    break;
            }
        }
    }
    
    
}
