using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System
{
    /*
    The DeliveryCenter struct should store up to 10 shipments using a private Shipment[] array.

    Add an integer indexer:
         -Returns the shipment at the given position.
         -Allows replacing a shipment.
         -If the index is invalid, the getter returns default.
         -If the index is invalid while setting, do nothing.

    Add a string indexer:
	    -Returns the first shipment with the matching tracking code.
	    -Returns default if no matching shipment is found.

    Add Method named AddShipment:
        -Adds the shipment to the first available position.
        -Returns true if the shipment was added successfully.
        -Returns false if the delivery center is full. 

     */

    public struct DeliveryCenter
    {
        private Shipment[] shipments;
        public DeliveryCenter()
        {
            
            shipments= new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= shipments.Length)
                    return default;

                return shipments[index];
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i=0; i<shipments.Length;i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (string.IsNullOrEmpty(shipments[i].TrackingCode))
                {
                    shipments[i] = shipment;
                    return true; 
                }
            }
            return false; 
        }
    }
}

