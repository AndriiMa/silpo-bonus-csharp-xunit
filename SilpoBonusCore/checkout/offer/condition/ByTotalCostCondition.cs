namespace SilpoBonusCore{

    public class ByTotalCostCondition : ICondition
    {
        private int requiredCost;

        public ByTotalCostCondition(int requiredCost)
        {
            this.requiredCost = requiredCost;
        }

        public bool IsSatisfy(Check check)
        {
           return check.GetTotalCost() >= requiredCost;
        }
    }

}