using NUnit.Framework;
using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestOrderProcess
{
    public class BookProductTest
    {
        [Test]
        public void bookProductNoException()
        {
            //Arrange
            IOrder order = new BookProduct();
            int result;

            //Assert
            Assert.DoesNotThrow(() => order.ActionTaken(out result));
        }

        [Test]
        public void bookProductSuccessTest()
        {
            //Arrange
            IOrder order = new BookProduct();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1,result);
        }

        [Test]
        public void bookProductFailureTest()
        {
            //Arrange
            IOrder order = new BookProduct();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }

       
    }
}