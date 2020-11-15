using OrderProcessing.src.order.processing.exception;
using OrderProcessing.src.order.processing.orderInterface;
using OrderProcessing.src.order.processing.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.OrderFactory
{
    public class OrderProcess
    {
        private IOrder _order;

        public IOrder GetOrder(int orderType)
        {
            try
            {
                switch (orderType)
                {
                    case 1:
                        _order = new PhysicalProduct();
                        break;
                    case 2:
                        _order = new BookProduct();
                        break;
                    case 3:
                        _order = new NewMembership();
                        break;
                    case 4:
                        _order = new UpgradeMembership();
                        break;
                    default:
                        Console.WriteLine("Invalid entry!");
                        break;
                }

            }
            catch (Exception e)
            {
                // result = 0;
                Logexception.obj.Log("Error: " + e.Message);
            }

            return _order;
        }
    }
}
