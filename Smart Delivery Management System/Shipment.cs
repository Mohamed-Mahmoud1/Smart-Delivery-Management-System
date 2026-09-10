using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    public struct Shipment
    {
        /*
         
   2.Add constructor overloading to Shipment:
   -The first constructor receives only trackingCode.
   -The first constructor uses default values: Description = "Unknown", Weight = 1, DeliveryFee = 50, and a default destination.
   -The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
   -Each constructor must initialize the object with valid data.
        
    public Shipment(string trackingCode)
    {
     Initialize the shipment using default values.
    }

    public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    {
     Initialize the shipment using the provided values.
    }
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

   


    }

}
