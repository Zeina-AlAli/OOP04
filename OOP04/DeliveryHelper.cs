using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    static internal class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            shipment.PrintShipment(); // Dynamic Polymorphism: method determined at runtime based on the actual object type (StandardShipment, ExpressShipment, or CompletedShipment)
        }


    }
}
