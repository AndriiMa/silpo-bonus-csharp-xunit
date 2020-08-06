using System;
using SilpoBonusCore.Tests;

namespace SilpoBonusCore
{
    public class CheckoutService
    {
        private Check check;

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
            Check closedCheck = this.check;
            this.check = null;
            return closedCheck;
        }

        public void useOffer(AnyGoodsOffer offer)
        {
            if(offer.GetTotalCost() <= this.check.GetTotalCost())
            this.check.AddPoints(offer.GetPoints());

        }
    }
}