using System;

namespace SilpoBonusCore
{
    public class AnyGoodsOffer : Offer
    {
        private int totalCost;
        private int points;

        public AnyGoodsOffer(int totalCost,
                             int points,
                             DateTime expirationDate) : base(expirationDate)
        {
            this.totalCost = totalCost;
            this.points = points;
        }

        public int GetTotalCost()
        {
            return this.totalCost;
        }

        public int GetPoints()
        {
            return this.points;
        }

        public override void AddPoints(Check check)
        {
            if (GetTotalCost() <= check.GetTotalCost())
            {
                check.AddPoints(GetPoints());
            }
        }
    }
}