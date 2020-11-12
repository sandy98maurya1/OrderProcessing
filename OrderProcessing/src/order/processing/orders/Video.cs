using OrderProcessing.src.order.processing.exception;
using OrderProcessing.src.order.processing.orderInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.orders
{
    class Video : IOrder
    {
        public void ActionTaken()
        {
            try
            {
                Console.WriteLine("Add a free First Aid video to the packing slip");
            }
            catch (Exception e)
            {
                Logexception.obj.Log("Error: " + e.Message);
            }
        }
    }
}
