using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.OrderFactory
{
    public class OrderProcess
    {
        IOrder order;
        public IOrder GetOrder(int orderType)
        {
            switch (orderType)
            {
                case 1:
                    order = new PhysicalProduct();
                    break;
                case 2:
                    order = new BookProduct();
                    break;
                case 3:
                    order = new NewMembership();
                    break;
                case 4:
                    order = new UpgradeMembership();
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
            }
            return order;
        }
    }
}
