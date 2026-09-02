using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStudy.Entities.Enums
{
    internal class OrderStatus
    {
        // Declaring an object lifecycle

        enum Status : int {

            // Here, the object's statuses will be defined.
            PendingPayment = 1,
            Processing = 2,
            Shipped = 3,
            Delivered = 4
        }


    }
}
