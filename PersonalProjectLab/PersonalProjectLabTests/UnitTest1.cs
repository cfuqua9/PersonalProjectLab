using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;
namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SoupMethod()
        {
            //arrange
            Order order = new Order();

            //act
            order.addordertype("soup");
            order.addorderdetail("tomatoe",0);
            string details = order.getorderdetails();

            //assert
            Assert.AreEqual("tomatoe soup", details);

        }
        [TestMethod]
        public void SaladMethod()
        {
            //arrange
            Order order = new Order();

            //act
            order.addordertype("salad");
            order.addorderdetail("croutons", 0);
            string toppings = order.getorderdetails();

            //assert
            Assert.AreEqual("salad with croutons", toppings);

        }
    }
}
