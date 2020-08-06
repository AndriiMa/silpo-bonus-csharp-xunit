namespace SilpoBonusCore.Checkout{

    public class Product{

        private int price;
        private string name;
        private Category category;

        public Product(int price, string name, Category category)
        {
            this.price = price;
            this.name = name;
            this.category = category;
        }

        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }
        
    }

}