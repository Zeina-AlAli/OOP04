using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal abstract class Shipment
    {

        //Properties
        private string trackingCode;

        public string TrackingCode
        {
            get
            { return trackingCode; }

            set
            {
                if (string.IsNullOrEmpty(value))
                { return; }

                else
                { trackingCode = value; }
            }
        }
        private string description;

        public string Description
        {

            get
            { return description; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    return;

                description = value;
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }

            set
            {
                if (value <= 0) return;

                weight = value;


            }
        }
        private decimal deliveryfee;

        public decimal DeliveryFee
        {
            get;
            private set
            {
                if (value <= 0) return;

                deliveryfee = value;
            }
        }

        // Composition
        public DeliveryAddress Address;

        private DeliveryAddress destination;

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        //public virtual double EstimatedCost
        //{
        //    get { return (double)DeliveryFee * (Weight * 5.0); }
        //}
       

        //Constructors

        public Shipment(string trackingCode) //1
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryfee, DeliveryAddress destination) //2
        {
            TrackingCode = trackingCode;
            Destination = destination;
            DeliveryFee = deliveryfee;
            Weight = weight;
            Description = description;
            this.destination = destination;
        }
        // Methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        //public virtual void PrintShipment()
        //{

        //    Console.WriteLine("TrackingCode: " + TrackingCode);
        //    Console.WriteLine("Description: " + Description);
        //    Console.WriteLine("Weight: " + Weight + " EGP");
        //    Console.WriteLine("DeliveryFee: " + DeliveryFee + " EGP");
        //    Console.WriteLine("destination: " + Destination);
        //    Console.WriteLine("Estimated cost: \n" + EstimatedCost + " EGP");

        //}

        //method overloading
        public void UpdateWeight(double newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(double newWeight, double extraWeight)
        {
            if (newWeight > 0 && extraWeight > 0)
                Weight = newWeight + extraWeight;
        }
        
        //Abstract Property & Method
        public abstract decimal EstimatedCost { get;  }
        public abstract void PrintShipment();


    }
}
