using Moq;
using NUnit.Framework;
using OrderProcessing.src.order.processing.OrderFactory;
using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;

namespace NUnitTestOrderProcess
{
    public class Tests
    {

        [Test]
        public void OrderFactory_Should_Create_Order()
        {
            //Arrange            
            var service = new OrderProcess();

            //Act
            IOrder actual = service.GetOrder(1);

            //Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOf(typeof(IOrder), actual);
        }

        [Test]
        public void orderProcessNoException()
        {
            //Arrange            
            var service = new OrderProcess();

            //Assert
            Assert.DoesNotThrow(() => service.GetOrder(1));
        }

        [Test]
        public void OrderProcess()
        {
            Assert.Pass();
        }
        //ssert.Pass();
    }
}