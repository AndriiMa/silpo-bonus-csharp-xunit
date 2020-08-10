using System.Linq;

namespace SilpoBonusCore{

    public class ByTradeCondition : ICondition
    {

        private string tradeMark;

        public ByTradeCondition(string tradeMark)
        {
            this.tradeMark = tradeMark;
        }

        public bool isSatisfy(Check check)
        {
            return check.GetProducts().Select(product => product.GetTradeMark())
            .Contains(tradeMark);
        } 
    }

}