namespace SilpoBonusCore
{

    public class FacrorByCategoryOffer : Offer
    {

        private Category category;
        private int factor;

        public FacrorByCategoryOffer(Category category, int factor)
        {
            this.category = category;
            this.factor = factor;
        }

        public override void Apply(Check check)
        {
            int points = check.GetCostByCategory(category);
            check.AddPoints(points * (factor - 1));
        }
    }

}