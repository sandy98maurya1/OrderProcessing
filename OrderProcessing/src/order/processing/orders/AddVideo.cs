using OrderProcessing.src.order.processing.exception;
using OrderProcessing.src.order.processing.orderInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.orders
{
    public class AddVideo : IOrder
    {
        public void ActionTaken(out int result)
        {
            try
            {
                Console.WriteLine("Add a free First Aid video to the packing slip");
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
