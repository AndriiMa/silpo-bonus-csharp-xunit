namespace SilpoBonusCore{

    public class ByTotalCostCondition : ICondition
    {
        private int requiredCost;

        public ByTotalCostCondition(int requiredCost)
        {
            this.requiredCost = requiredCost;
        }

        public bool isSatisfy(Check check)
        {
           return check.GetTotalCost() >= requiredCost;
        }
    }

}