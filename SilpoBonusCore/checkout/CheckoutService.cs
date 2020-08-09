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
            UseOffers();

            Check closedCheck = this.check;
            this.check = null;
            return closedCheck;
        }

        public void AddOffer(Offer offer)
        {
                this.offers.Add(offer);
        }

        private void UseOffers()
        {
            offers.ForEach(o => o.UseOffer(check));
        }
    }
}