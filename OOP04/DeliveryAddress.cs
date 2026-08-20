using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal struct DeliveryAddress
    {
        // Properties
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }

        // Constructor
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        // method to display the address
        public override string ToString()
        {
            return $"City: {City} \n Street: {Street} \n Building Number: {BuildingNumber}";
        }



    }
}
