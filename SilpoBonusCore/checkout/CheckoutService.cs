using System;
using System.Collections.Generic;

namespace SilpoBonusCore
{
    public class CheckoutService
    {
        private Check check;
        private List<Offer> offers = new List<Offer>();
        public void OpenCheck()
        {
            this.check = new Check();
        }

        public void AddProduct(Product product)
        {
            if (this.check == null)
            {
                OpenCheck();
            }
            this.check.AddProduct(product);
        }

        public Check CloseCheck()
        {
            ApplyOffers();

            Check closedCheck = this.check;
            this.check = null;
            return closedCheck;
        }

        public void UseOffer(Offer offer)
        {
            if (offer.IsExpired())
            {
                this.offers.Add(offer);
            }
        }

        private void ApplyOffers()
        {
            offers.ForEach(o => o.Apply(check));
        }
    }
}