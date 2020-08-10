using System.Linq;

namespace SilpoBonusCore{

    public class ByCategoryCondition : ICondition
    {
        private Category category;

        public ByCategoryCondition(Category category)
        {
            this.category = category;
        }

        public bool isSatisfy(Check check)
        {
            return check.GetProducts().Select(product => product.GetCategory())
            .Contains(category);
        } 
    }
}