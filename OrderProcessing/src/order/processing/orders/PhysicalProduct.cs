using OrderProcessing.src.order.processing.exception;
using OrderProcessing.src.order.processing.orderInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.orders
{
    public class PhysicalProduct : IOrder
    {
        public void ActionTaken()
        {
            try
            {
                Console.WriteLine("Generate a packing slip for shipping.");
                Console.WriteLine("Generate a commision payment to the agent.");
            }
            catch (Exception e)
            {
                Logexception.obj.Log("Error: " + e.Message);
            }
        }
    }
}
