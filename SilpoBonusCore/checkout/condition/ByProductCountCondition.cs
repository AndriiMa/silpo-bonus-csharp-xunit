namespace SilpoBonusCore
{
    public class ByProductCountCondition : ICondition
    {

        private int requiredAmount;

        public ByProductCountCondition(int requiredAmount)
        {
            this.requiredAmount = requiredAmount;
        }

        public bool isSatisfy(Check check)
        {
            return check.GetProducts().Count >= requiredAmount;
        }
    }
}