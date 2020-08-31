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

        /// <summary>
        /// To get details of indiviual product 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// get Id of the product from input
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetProductID(string id)
        {
            string Id = id.Substring(id.Length - 1);
            return Id;
        }

        /// <summary>
        /// get value of the product for specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetProductValue(string id)
        {
            int Value = Convert.ToInt32(id.Substring(0,1));
            return Value;
        }

        /// <summary>
        /// Get Total price for the products
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public static int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;

            //condition to make price Value 0 when product count is 4
            if (products.Count == 4)
            {
                priceofC = 0;
            }

            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = pr.Value;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = pr.Value;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = pr.Value;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = pr.Value;
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;
        }
    }
}
