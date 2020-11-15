using NUnit.Framework;
using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestOrderProcess
{
    public class UpgradeMembershipTest
    {
        [Test]
        public void upgradeMembershipNoException()
        {
            //Arrange
            IOrder order = new UpgradeMembership();
            int result;

            //Assert
            Assert.DoesNotThrow(() => order.ActionTaken(out result));
        }

        [Test]
        public void upgradeMembershipSuccessTest()
        {
            //Arrange 
            IOrder order = new UpgradeMembership();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void upgradeMembershipFailureTest()
        {
            // upgradeMembership
            IOrder order = new UpgradeMembership();
            int result;

            //Act
            order.ActionTaken(out result);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
