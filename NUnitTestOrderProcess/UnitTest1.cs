using NUnit.Framework;
using OrderProcessing.src.order.processing.OrderFactory;
using OrderProcessing.src.order.processing.orderInterface;

namespace NUnitTestOrderProcess
{
    public class Tests
    {

        [Test]
        public void CinemaFactory_Should_Create_Cinema()
        {
            //Arrange
            var OrderProcessFactory = new OrderProcess();

            //Act
            IOrder actual = OrderProcessFactory.GetOrder(1);

            //Assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOf(typeof(IOrder), actual);
        }
    }
}