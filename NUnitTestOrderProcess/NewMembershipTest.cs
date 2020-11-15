using NUnit.Framework;
using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestOrderProcess
{
    public class NewMembershipTest
    {
        [Test]
        public void newMembershipNoException()
        {
            //Arrange
            IOrder order = new NewMembership();
            int result;

            //Assert
            Assert.DoesNotThrow(() => order.ActionTaken(out result));
        }

        [Test]
        public void NewMembershipSuccessTest()
        {
            //Arrange
            IOrder order = new NewMembership();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void NewMembershipFailureTest()
        {
            //Arrange
            IOrder order = new NewMembership();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
