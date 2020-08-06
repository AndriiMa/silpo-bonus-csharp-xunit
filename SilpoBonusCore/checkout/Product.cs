namespace SilpoBonusCore
{

    public class Product
    {

        private int price;
        private string name;
        private Category category;

        public Product(int price, string name, Category category)
        {
            this.price = price;
            this.name = name;
            this.category = category;
        }

        public Product(int price, string name) : this(price, name, Category.NONE) { }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetName()
        {
            return this.name;
        }

        public Category GetCategory()
        {
            return this.category;
        }

    }

}