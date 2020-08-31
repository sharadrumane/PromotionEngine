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

        public Product()
        {
        }

        public Product GetProductDetails(string id)
        {
            Product product = new Product();
            product.Id = GetProductID(id);
            product.Value = GetProductValue(id);

            if (product.Id == "A" || product.Id == "a")
                product.Price = 50m;
            else if (product.Id == "B" || product.Id == "b")
                product.Price = 30m;
            else if (product.Id == "C" || product.Id == "c")
                product.Price = 20m;
            else if (product.Id == "D" || product.Id == "d")
                product.Price = 15m;

            return product;
        }

        public string GetProductID(string id)
        {
            char[] spearator = { '*', ' ' };
            String[] strlist = id.Split(spearator);
            string Id = strlist[1];

            return Id;
        }

        public int GetProductValue(string id)
        {
            char[] spearator = { '*', ' ' };
            String[] strlist = id.Split(spearator);
            int Value = Convert.ToInt32(strlist[0]);

            return Value;
        }
    }
}
