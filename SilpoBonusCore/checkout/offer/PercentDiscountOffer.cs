using System;
using System.Collections.Generic;
namespace SilpoBonusCore
{

    public class PercentDiscountOffer : Offer
    {

        private string productName;

        private int percent;
        private DateTime expirationDate;

        public PercentDiscountOffer(string productName,
                                    int percent,
                                    DateTime expirationDate) : base(expirationDate)
        {
            this.productName = productName;
            this.percent = percent;
            this.expirationDate = expirationDate;
        }

        public override void Apply(Check check)
        {
            List<Product> products = check.GetProducts();
            foreach (Product product in products)
            {
                if (product.GetName().Equals(productName))
                {
                    product.SetPrice(getDiscount(product.GetPrice()));
                }
            }
        }

        private int getDiscount(int price)
        {
            return (price * this.percent) / 100;
        }
    }
}