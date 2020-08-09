namespace SilpoBonusCore
{

    public class Product
    {

        private int price;
        private string name;

        private string tradeMark;
        private Category category;

        public Product(int price, string name, Category category, string tradeMark)
        {
            this.price = price;
            this.name = name;
            this.category = category;
            this.tradeMark = tradeMark;
        }

        public Product(
            int price,
            string name,
            string tradeMark) : this(price, name, Category.NONE, tradeMark) { }

        public int GetPrice()
        {
            return this.price;
        }

        internal void SetPrice(int price){
            this.price = price;
        }

        public string GetName()
        {
            return this.name;
        }

        public Category GetCategory()
        {
            return this.category;
        }

        public string GetTradeMark(){
            return this.tradeMark;
        }

    }

}