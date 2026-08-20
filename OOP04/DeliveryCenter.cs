using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class DeliveryCenter
    {

        public string CenterName { get; set; }

        private Shipment?[] shipments = new Shipment?[20];
        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                return null;
            }
            set
            {

                if (index >= 0 && index < shipments.Length)
                {
                    if (value != null)
                    {
                        shipments[index] = value;
                    }
                }

            }

        }

        // Aggregation property
        public Driver Driver { get; set; }

        public Shipment? this[string trackingCode]
        {
            get
            {
                if (shipments != null && trackingCode != null)
                {
                    foreach (Shipment shipment in shipments)
                    {
                        if (shipment is not null)
                            if (shipment.TrackingCode == trackingCode)
                            {
                                return shipment;

                            }
                    }
                }
                return null;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        //Assignment02 Methods:
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] is not null)

                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        shipments[i] = null; return true;
                    }
            }
            return false;
        }

        // Dynamic Polymorphism: PrintShipment method
        public void PrintAllShipments()
        {
            foreach (Shipment s in shipments)
            {
                if (s is not null)
                {
                    Console.WriteLine(s.GetType().Name+":\n");
                    s.PrintShipment();
                }
            }
        }

        // Printing tracking status using Itrackable interface
        public void PrintTrackingStatuses()
        {
            foreach(ITrackable t in shipments)
            {
                if(t is not null)

                Console.WriteLine(t.GetTrackingStatus());
                Console.WriteLine();
            }
        }

        // Calculatte Insurance for each shipment and printing it

        public void PrintInsuranceCost()
        {
            foreach(IInsurable i in shipments)

            {
                if( i is not null)

                Console.WriteLine( i.CalculateInsurance());
            }
        }




    }
}
