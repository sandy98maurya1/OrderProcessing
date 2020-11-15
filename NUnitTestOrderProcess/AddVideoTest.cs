using NUnit.Framework;
using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestOrderProcess
{
    public class AddVideoTest
    {
        [Test]
        public void addVideoNoException()
        {
            //Arrange
            IOrder order = new AddVideo();
            int result;

            //Assert
            Assert.DoesNotThrow(() => order.ActionTaken(out result));
        }

        [Test]
        public void addVideoSuccessTest()
        {
            //Arrange 
            IOrder order = new AddVideo();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void addVideoFailureTest()
        {
            // upgradeMembership
            IOrder order = new AddVideo();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
