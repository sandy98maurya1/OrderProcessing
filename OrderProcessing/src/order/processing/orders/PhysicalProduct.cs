using OrderProcessing.src.order.processing.exception;
using OrderProcessing.src.order.processing.orderInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.orders
{
    public class PhysicalProduct : IOrder
    {
        public void ActionTaken(out int result)
        {
            try
            {
                Console.WriteLine("Generate a packing slip for shipping.");
                Console.WriteLine("Generate a commision payment to the agent.");
                result = 1;

            }
            catch (Exception e)
            {
                result = 0;

                Logexception.obj.Log("Error: " + e.Message);
            }
        }
    }
}
