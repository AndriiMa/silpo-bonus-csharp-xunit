namespace SilpoBonusCore.Tests
{
    public class AnyGoodsOffer
    {
        private int totalCost;
        private int points;

        public AnyGoodsOffer(int totalCost, int points)
        {
            this.totalCost = totalCost;
            this.points = points;
        }

        public int GetTotalCost(){
            return this.totalCost;
        }

        
        public int GetPoints(){
            return this.points;
        }
    }
}