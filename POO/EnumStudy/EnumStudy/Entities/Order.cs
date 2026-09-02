using System;
using EnumStudy.Entities.Enums;

namespace EnumStudy.Entities
{
    internal class Order
    { 
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } // Property that will receive the enum status 
    }
}
