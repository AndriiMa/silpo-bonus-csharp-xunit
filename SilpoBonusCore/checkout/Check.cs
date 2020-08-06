using System.Collections.Generic;
using System.Linq;

namespace SilpoBonusCore.Checkout
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

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void AddPoints(int points){
            this.points += points;
        }

        public int GetCostByCategory(Category category){
            return products.Where(p => p.GetCategory().Equals(category))
            .Sum(p=> p.GetPrice());           
        }
    }

}