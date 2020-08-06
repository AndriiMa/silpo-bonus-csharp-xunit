namespace SilpoBonusCore{

    public class FacrorByCategory : Offer{

    private Category category;
    private  int factor;
        public override void Apply(Check check)
        {
            int points = check.GetCostByCategory(category);
            check.AddPoints(points * (factor - 1));
        }
    }

}