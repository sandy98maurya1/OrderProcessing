using OrderProcessing.src.order.processing.exception;
using OrderProcessing.src.order.processing.orderInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.orders
{
    public class NewMembership : IOrder
    {
        public void ActionTaken()
        {
            try { 
            Console.WriteLine("Activate membership.");
            Console.WriteLine("Inform user through email about new membership");
            }
            catch (Exception e)
            {
                Logexception.obj.Log("Error: " + e.Message);
            }
        }
    }
}
