using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class CheckoutServiceTest{

        [Fact]
        public void Close_Check_with_One_Product(){
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();
            checkoutService.AddProduct(new Product(7, "Milk", Category.MILK));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        public void Close_Check_with_Two_Product(){
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();
            checkoutService.AddProduct(new Product(7, "Milk", Category.MILK));
            checkoutService.AddProduct(new Product(3, "Bread"));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(check.GetTotalCost(), 10);
        }


    }

}
