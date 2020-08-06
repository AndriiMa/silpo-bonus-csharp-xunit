using System;
using System.Collections.Generic;
using System.Linq;

namespace SilpoBonusCore
{
    public class Check
    {
        private List<Product> products = new List<Product>();

        private int points = 0;
        public int GetTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in this.products)
            {
                totalCost += product.GetPrice();
            }
            return totalCost;
        }

        internal void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        internal void AddPoints(int points){
            this.points += points;
        }

        public int GetCostByCategory(Category category){
            return products.Where(p => p.GetCategory().Equals(category))
            .Sum(p=> p.GetPrice());           
        }

        public int GetTotalPoints()
        {
            return GetTotalCost() + points;
        }
    }

}