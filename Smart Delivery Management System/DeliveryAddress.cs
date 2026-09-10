using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Smart_Delivery_Management_System
{
    public struct DeliveryAddress
    {
       /*
       1.Create a DeliveryAddress struct with:
       City of type string.
       Street of type string.
       BuildingNumber of type int.
       A constructor that initializes all fields.
       A GetFullAddress() method that returns the complete address as one string.
       */

        public string City { get; set; }
        public string Street { get; set; }
        public int Building_Number  { get; set; }

        public DeliveryAddress(string city,string street,int building_number)
        {
            City= city;
            Street= street;
            Building_Number = building_number;
        }

        public void GetFullAddress()
        {
            Console.WriteLine($"City: {City}\nStreet: {Street}\nBuilding Number: {Building_Number}\n----------------");
        }

    }
}
