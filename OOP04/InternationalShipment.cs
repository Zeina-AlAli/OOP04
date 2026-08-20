using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class InternationalShipment : Shipment , ITrackable, IInsurable
        

    {
        private string destinationcuntry;

        public string DestinationCountry
        {
            get { return destinationcuntry; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    destinationcuntry = value;
            }
        }

        private decimal customerfee;

        public decimal CustomerFee
        {
            get { return customerfee; }
            set
            {
                if (value >= 0)

                    customerfee = value;
            }
        }

        // override EstimatedCode
        //public override double EstimatedCost => (double)DeliveryFee + (Weight * 5) + (double)CustomerFee;

        //Constructor chaining
        public InternationalShipment(string destinationcuntry, decimal customerfee, string trackingCode, string description, double weight, decimal deliveryfee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryfee, destination)
        {
            DestinationCountry = destinationcuntry;
            CustomerFee = customerfee;

        }

        // ovrride PrintShipment method
        //public override void PrintShipment()
        //{
        //    Console.WriteLine("\nInternational Shipment: \n");
        //    base.PrintShipment();
        //    Console.WriteLine("Destination Country: " + DestinationCountry);
        //    Console.WriteLine("Customer Fee: " + CustomerFee + " EGP");
        //    Console.WriteLine("EstimatedCost: " + EstimatedCost + " EGP");
        //    Console.WriteLine("\n-------------------------------------------------------------------------\n");
        //}


        // sealed method
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating customs report for shipment to " + DestinationCountry);
        }


        // Implement Abstract
        public override decimal EstimatedCost => ((decimal)Weight * 5) + CustomerFee;

        public override void PrintShipment()
        {
            Console.WriteLine("Tracing Code: " + TrackingCode);
            Console.WriteLine("Destination Country: " + DestinationCountry);
            Console.WriteLine("EstimatedCost: " + EstimatedCost + " EGP");
            Console.WriteLine("\n-------------------------------------------------------------------------\n");
        }


        // Implement Interface
        public string GetTrackingStatus()
        {
            return "Shipment SH003 has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            Console.Write("International Shipment Isurance: ");
            return 12 * EstimatedCost / 100;
        }
    }
}
