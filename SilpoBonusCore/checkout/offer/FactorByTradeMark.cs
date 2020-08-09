using System;
using System.Linq;

namespace SilpoBonusCore
{

    public class FactorByTradeMark : Offer
    {
        private string tradeMark;
        private int pointsForEach;

        public FactorByTradeMark(string tradeMark, int pointsForEach, DateTime expirationDate) : base(expirationDate)
        {
            this.tradeMark = tradeMark;
            this.pointsForEach = pointsForEach;
        }

        public override void AddPoints(Check check)
        {

            check.AddPoints(CalculatePoints(check));
        }

        private int CalculatePoints(Check check)
        {
            return GetTradeMarkCount(check) * pointsForEach;
        }

        private int GetTradeMarkCount(Check check)
        {
            return check.GetProducts().Select(product => product.GetTradeMark())
            .Where(tm => tm.Equals(this.tradeMark))
            .Count();
        }
    }
}