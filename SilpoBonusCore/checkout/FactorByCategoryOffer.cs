using System;

namespace SilpoBonusCore
{

    public class FacrorByCategoryOffer : Offer
    {

        private Category category;
        private int factor;

        public FacrorByCategoryOffer(Category category, 
                                    int factor,
                                    DateTime expirationDate):base(expirationDate)
        {
            this.category = category;
            this.factor = factor;
        }

        public override void AddPoints(Check check)
        {
            int points = check.GetCostByCategory(category);
            check.AddPoints(points * (factor - 1));
        }
    }

}