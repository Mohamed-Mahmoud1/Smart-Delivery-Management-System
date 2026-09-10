using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    public struct Shipment
    {

        /*
         3.Add the following methods to Shipment:
	    -UpdateDeliveryFee(decimal newFee): updates the fee only when newFee is greater than 0.
	    -PrintShipment(): prints all shipment information, including the estimated cost.
         */

        string _TackingCode;
        string _Description;
        double _Weight;
        double _DeliveryFee;
        public Shipment(string trackingCode)
        {
           TrackingCode = trackingCode;
           Description = "Unknown";
           Weight = 1;
           DeliveryFee=50;
           Destination = default;
        }

        public Shipment(string tackingCode, string description, double weight, double deliveryFee,DeliveryAddress destination) : this()
        {
            _TackingCode = tackingCode;
            _Description = description;
            _Weight = weight;
            _DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public string TrackingCode
        {
            get
            {
                return _TackingCode;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _TackingCode= value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _Description = value;
            }
        }

        public double Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                if (value > 0)
                    _Weight = value;
            }
        }

        public double DeliveryFee
        {
           get
            {
                return _DeliveryFee;
            }
            private set
            {
                if (value > 0)
                    _DeliveryFee = value;
            }
        }

        public double EstimatedCost => DeliveryFee + (Weight * 5);
        public DeliveryAddress Destination { get; set; }

        public override string ToString()
        {
            return 
                $"Tracking Code: {TrackingCode}\n" +
                $"Description: {Description}\n" +
                $"Weight: {Weight}\n" +
                $"Delivery Fee: {DeliveryFee}\n" +
                $"Estimated Cost: {EstimatedCost}\n" +
                $"Destination: {Destination.City}, {Destination.Street}, {Destination.Building_Number}" +
                $"\n-------------------------------------------------";
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = (double)newFee;
             
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination: {Destination.City}, {Destination.Street}, {Destination.Building_Number}");
            Console.WriteLine("-------------------------------------------------");
        }

    }

}
