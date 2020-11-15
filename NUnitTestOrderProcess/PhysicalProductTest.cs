using NUnit.Framework;
using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestOrderProcess
{
    public class PhysicalProductTest
    {
        [Test]
        public void physicalProductNoException()
        {
            //Arrange
            IOrder order = new PhysicalProduct();
            int result;

            //Assert
            Assert.DoesNotThrow(() => order.ActionTaken(out result));
        }

        [Test]
        public void physicalProductSuccessTest()
        {
            //Arrange 
            IOrder order = new PhysicalProduct();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void physicalProductFailureTest()
        {
            //Arrange
            IOrder order = new PhysicalProduct();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
