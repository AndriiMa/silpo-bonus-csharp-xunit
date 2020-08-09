using System;
using System.Collections.Generic;

namespace SilpoBonusCore{
public class GiftDiscountOffer : Offer
    {

        private string productName;

        private DateTime expirationDate;

        public GiftDiscountOffer(string productName,
                                    DateTime expirationDate) : base(expirationDate)
        {
            this.productName = productName;
            this.expirationDate = expirationDate;
        }

        public override void Apply(Check check)
        {
            List<Product> products = check.GetProducts();
            foreach (Product product in products)
            {
                if (product.GetName().Equals(productName))
                {
                    product.SetPrice(1);
                }
            }
        }
    }
}
