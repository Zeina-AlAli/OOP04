using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP04
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryfee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryfee, destination)
        {

        }

        // override EstimatedCode unmodified
        // public override double EstimatedCost => base.EstimatedCost;


        // Implement Abstract Property & Method
        public override decimal EstimatedCost => DeliveryFee * (decimal)(Weight * 5.0);

        public override void PrintShipment()
        {
            Console.WriteLine("Tracing Code: " + TrackingCode);
            Console.WriteLine("Description: "+ Description);
            Console.WriteLine("Estimated Cost: " + EstimatedCost);
            Console.WriteLine("\n-------------------------------------------------------------------------\n");
        }

        // Implement Interface
        public string GetTrackingStatus()
        {
            return "Shipment SH001 is Ready";
        }

        public decimal CalculateInsurance()
        {
            Console.Write("Standard Shipment Isurance: ");
            return 5 * EstimatedCost/100;
        }


    }
}
