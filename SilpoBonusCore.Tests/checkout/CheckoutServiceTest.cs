using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class CheckoutServiceTest
    {
        private Product milk;
        private Product bread;
        private CheckoutService checkoutService;

        public CheckoutServiceTest()
        {
            checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            milk = new Product(7, "Milk", Category.MILK);
            bread = new Product(3, "Bread");
        }




        [Fact]
        public void Close_Check_with_One_Product()
        {
            checkoutService.AddProduct(milk);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        public void Close_Check_with_Two_Product()
        {
            checkoutService.AddProduct(milk);
            checkoutService.AddProduct(bread);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 10);
        }

        [Fact]
        public void Should_Calculate_Total_Cost()
        {
            checkoutService.AddProduct(milk);
            checkoutService.AddProduct(bread);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(10, check.GetTotalCost());
        }

        [Fact]
        public void When_AddProduct_Should_Add_Products_To_New_Check()
        {
            checkoutService.AddProduct(milk);

            Check milkCheck = checkoutService.CloseCheck();

            Assert.Equal(milkCheck.GetTotalCost(), 7);

            checkoutService.AddProduct(bread);

            Check breadCheck = checkoutService.CloseCheck();

            Assert.Equal(breadCheck.GetTotalCost(), 3);

        }

        [Fact]
        public void When_Get_Total_Points_Should_Return_Points()
        {
            checkoutService.AddProduct(milk);
            checkoutService.AddProduct(bread);

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 10);
        }


        [Fact]
        public void When_useOffer_Should_Add_Offer_Points()
        {
            checkoutService.AddProduct(milk);
            checkoutService.AddProduct(bread);

            checkoutService.UseOffer(new AnyGoodsOffer(6, 2, new DateTime(2025, 10, 20)));

            Check check = checkoutService.CloseCheck();

            Assert.Equal(12, check.GetTotalPoints());
        }

        [Fact]
        public void When_useOffer_With_Cost_Less_Requare_Should_Not_Add_Offer_Points()
        {
            checkoutService.AddProduct(bread);

            checkoutService.UseOffer(new AnyGoodsOffer(6, 2, new DateTime(2025,10,20)));

            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalPoints(), 3);
        }

       

        [Fact]
        void useOffer__factorByCategory() {
            checkoutService.AddProduct(milk);
            checkoutService.AddProduct(milk);
            checkoutService.AddProduct(bread);

            checkoutService.UseOffer(new FacrorByCategoryOffer(Category.MILK, 2, new DateTime(2025,10,20)));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(31, check.GetTotalPoints());
        }

        [Fact]
        void Should_Not_Apply_Offer_When_expirationTime_Less(){
            checkoutService.AddProduct(milk);
            checkoutService.AddProduct(milk);

            checkoutService.UseOffer(new FacrorByCategoryOffer(Category.MILK, 2, new DateTime(2019,10,20)));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(14, check.GetTotalPoints());
        }


    }

}
