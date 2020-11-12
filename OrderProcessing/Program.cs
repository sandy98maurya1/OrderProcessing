using OrderProcessing.src.order.processing.OrderFactory;
using OrderProcessing.src.order.processing.orderInterface;
using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 : PhysicalProduct");
            Console.WriteLine("2 : BookProduct");
            Console.WriteLine("3 : NewMembership");
            Console.WriteLine("4 : UpgradeMembership");


            int OrderType = Convert.ToInt16(Console.ReadLine());
            IOrder objOrder;
            OrderProcess obj = new OrderProcess();
            objOrder = obj.GetOrder(OrderType);
            objOrder.ActionTaken();

            Console.ReadLine();
        }

    }
}

