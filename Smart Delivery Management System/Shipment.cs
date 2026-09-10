using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    public struct Shipment
    {
        /*
         
    the struct should contain the following private fields:
        -TrackingCode
        -Description
        -Weight
        -DeliveryFee

        It should also contain a public property:
        -Destination (DeliveryAddress)

    Apply proper encapsulation using public properties with the following validation rules:
	    -TrackingCode cannot be null, empty, or whitespace.
	    -Description cannot be null, empty, or whitespace.
	    -Weight must be greater than 0.
	    -DeliveryFee must be greater than 0.
	    If an invalid value is assigned, keep the previous valid value.

    Add the following properties:
	    -TrackingCode: read-only from outside the struct.
	    -Description: read/write property with validation.
	    -Weight: read/write property with validation.
	    -DeliveryFee: public getter and private setter.
	    -Destination: public read/write property.
	    -EstimatedCost: a calculated property that returns: DeliveryFee + (Weight × 5)
        -The EstimatedCost value must be calculated when requested and must not be stored in a separate field 

        */
        string _TackingCode;
        string _Description;
        double _Weight;
        double _DeliveryFee;
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

   


    }

}
