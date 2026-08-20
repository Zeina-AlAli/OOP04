using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class ExpressShipment : Shipment, ITrackable,IInsurable
    {
        //Property
        private decimal extrafee;
        public decimal ExtraFee
        {
            get { return (decimal)EstimatedCost + extrafee; }
            set { if (value >= 0) { extrafee = value; } }
        }

        // override EstimatedCost
       // public override double EstimatedCost => base.EstimatedCost +(double)extrafee  ;


        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryfee, DeliveryAddress destination, decimal ExtraFee) : base(trackingCode, description, weight, deliveryfee, destination)
        {
            ExtraFee = extrafee;
        }

        // override PrintShipment method
        //public override void PrintShipment()
        //{
        //    Console.WriteLine("\nExpress Shipment: \n");
        //    base.PrintShipment();
        //    Console.WriteLine("Extra Fee: " + ExtraFee + " EGP");
        //    Console.WriteLine("EstimatedCost: " + EstimatedCost + " EGP");
        //    Console.WriteLine("\n-------------------------------------------------------------------------\n");

        //}

        //Implement Abstract
        public override decimal EstimatedCost => extrafee + (decimal)(Weight*5.0);

        public override void PrintShipment()
        { 

            Console.WriteLine("Tracking Code: " + TrackingCode);
            Console.WriteLine("Extra Fee: " + extrafee);
            Console.WriteLine("Estmated Code: " + EstimatedCost);
            Console.WriteLine("\n-------------------------------------------------------------------------\n");
        }

        // Implement Interface
        public string GetTrackingStatus()
        {
            return "Shipment SH002 is Out for Delivery";
        }

        public decimal CalculateInsurance()
        {
            Console.Write("Expree Shipment Isurance: ");
            return 8 * EstimatedCost / 100;
        }
    }
}
