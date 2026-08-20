using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
           string tr = shipment.GetTrackingStatus();
        }

        public void PrintInsurance(IInsurable shipment)
        {
           decimal ins = shipment.CalculateInsurance();
        }
    }
}
