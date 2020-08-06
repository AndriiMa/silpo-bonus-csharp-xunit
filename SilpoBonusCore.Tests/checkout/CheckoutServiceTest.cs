using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class CheckoutServiceTest
    {

        [Fact]
        public void Close_Check_with_One_Product()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk", Category.MILK));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        public void Close_Check_with_Two_Product()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk", Category.MILK));
            checkoutService.AddProduct(new Product(3, "Bread"));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 10);
        }

        [Fact]
        public void Whem_AddProduct_Should_Add_Products_To_New_Check()
        {
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk", Category.MILK));
            
            Check milkCheck = checkoutService.CloseCheck();
            Assert.Equal(milkCheck.GetTotalCost(), 7);

            checkoutService.AddProduct(new Product(3, "Bread"));
            Check breadCheck = checkoutService.CloseCheck();
            Assert.Equal(breadCheck.GetTotalCost(), 3);

        }


    }

}
