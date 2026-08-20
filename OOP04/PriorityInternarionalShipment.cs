using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class PriorityInternarionalShipment : InternationalShipment
    {
        public PriorityInternarionalShipment(string destinationcuntry, decimal customerfee, string trackingCode, string description, double weight, decimal deliveryfee, DeliveryAddress destination) : base(destinationcuntry, customerfee, trackingCode, description, weight, deliveryfee, destination)
        {
        }


        //override GeneratedTrackingCode method: mark it sealed
        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
        }
    }

}
