using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.src.order.processing.orderInterface
{
    public interface IOrder
    {
        void ActionTaken(out int result);
    }
}
