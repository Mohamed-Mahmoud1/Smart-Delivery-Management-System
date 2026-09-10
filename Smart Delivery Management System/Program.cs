using System.Data.SqlTypes;

namespace Smart_Delivery_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Question01
            //public struct DeliveryAddress
            //{
            //    public string City;
            //    public string Street;
            //}

            //public class Customer
            //{
            //    public string Name;
            //}

            //a)What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //Answer: When a DeliveryAddress variable is copied into another variable, a new instance of the struct is created. If the copy is modified, it does not affect the original variable because structs are value types.

            //b)What happens when a Customer variable is copied into another variable and one variable modifies the object
            //Answer: When a Customer variable is copied into another variable, both variables refer to the same object in memory because classes are reference types. If one variable modifies the object, the changes will be reflected in the other variable as well.


            #endregion

            #region Question02
            //public struct Shipment
            //{
            //public string Description;
            //public double Weight;
            //public decimal DeliveryFee;
            //}

            //a) Identify at least three problems with this design from an encapsulation perspective.
            //Answer:
            //1.Direct access to fields: The fields of the Shipment struct are public, which allows direct access and modification from outside the struct.
            //2.Lack of validation: There is no validation logic in place to ensure that the values assigned to the fields are valid.

            //b)How can private fields and public properties improve this design?
            //Answer: By using private fields and public properties, we can encapsulate the data and provide controlled access to it.
            #endregion

            #endregion

            #region Part 02 : Practical

            #region 1.Create a DeliveryAddress struct
            /*Create one DeliveryAddress value, 
             * copy it into a second variable, 
             * modify the copy, and print both values to prove that the original did not change.
             */


            //DeliveryAddress delivery_Address1 = new DeliveryAddress("New York", "5th Avenue", 123);
            //DeliveryAddress delivery_Address2 = new DeliveryAddress();
            //delivery_Address2 = delivery_Address1;

            //delivery_Address2.City = "Los Angeles";
            //delivery_Address2.Street = "Sunset Boulevard";
            //delivery_Address2.Building_Number = 456;

            //delivery_Address1.GetFullAddress();
            //delivery_Address2.GetFullAddress();


            #endregion

            #region 2.Add constructor overloading to Shipment:
            //Shipment shipment_obj01 = new Shipment("TestForTrackCode");
            //Console.WriteLine(shipment_obj01);

            //DeliveryAddress delivery_address_obj = new DeliveryAddress("TestForCity", "TestForStreet", 123);
            //Shipment shipment_obj02 = new Shipment("TestForTrackCode", "TestForDescription",80,100,delivery_address_obj);
            //Console.WriteLine(shipment_obj02);
            #endregion

            #region 3.Add the following methods to Shipment
            //Shipment shipment_obj01 = new Shipment("TestForTrackCode");
            //shipment_obj01.UpdateDeliveryFee(2000);
            //shipment_obj01.PrintShipment();
            #endregion

            #region 5.Create a DeliveryCenter struct
            //DeliveryCenter delivery_Center_obj = new DeliveryCenter();

            //DeliveryAddress delivery_address_obj01 = new DeliveryAddress("FirstCity", "FirstStreet", 1);
            //Shipment shipment_obj01 = new Shipment("FirstTrackCode", "FirstDescription", 1000,1000,delivery_address_obj01);

            //DeliveryAddress delivery_address_obj02 = new DeliveryAddress("SecondCity", "SecondStreet", 2);
            //Shipment shipment_obj02 = new Shipment("SecondTrackCode", "SecondDescription", 2000, 2000, delivery_address_obj02);

            //delivery_Center_obj.AddShipment(shipment_obj01);
            //delivery_Center_obj.AddShipment(shipment_obj02);

            //Console.WriteLine(delivery_Center_obj[0]);
            //Console.WriteLine(delivery_Center_obj["SecondTrackCode"]);

            #endregion

            #region 6. In Main, build a Console Application that does the following:
            //a.Create a DeliveryCenter.
            //b.Read data for three shipments from the user.
            //c.Create each Shipment and add it to the DeliveryCenter
            //d. Print the three shipments using the integer indexer.
            //e. Ask the user to enter a tracking code.
            //f. Search for the shipment using the string indexer
            //g.Print the shipment if found; otherwise print:Shipment not found.


            //DeliveryCenter delivery_Center_obj = new DeliveryCenter();

            //DeliveryAddress delivery_address_obj01 = new DeliveryAddress("FirstCity", "FirstStreet", 1);
            //Shipment shipment_obj01 = new Shipment("FirstTrackCode", "FirstDescription", 1000, 1000, delivery_address_obj01);

            //DeliveryAddress delivery_address_obj02 = new DeliveryAddress("SecondCity", "SecondStreet", 2);
            //Shipment shipment_obj02 = new Shipment("SecondTrackCode", "SecondDescription", 2000, 2000, delivery_address_obj02);

            //DeliveryAddress delivery_address_obj03 = new DeliveryAddress("ThirdCity", "ThirdStreet", 3);
            //Shipment shipment_obj03 = new Shipment("ThirdTrackCode", "ThirdDescription", 3000, 3000, delivery_address_obj03);

            //delivery_Center_obj.AddShipment(shipment_obj01);
            //delivery_Center_obj.AddShipment(shipment_obj02);
            //delivery_Center_obj.AddShipment(shipment_obj03);

            //Console.WriteLine(delivery_Center_obj[0]);
            //Console.WriteLine(delivery_Center_obj[1]);
            //Console.WriteLine(delivery_Center_obj[2]);

            //Console.Write("Enter Tracking Code:");
            //string tracking = Console.ReadLine();

            //if (delivery_Center_obj[tracking].TrackingCode != null)
            //    Console.WriteLine($"\n{delivery_Center_obj[tracking]}");
            //else
            //    Console.WriteLine("Shipment not found");

            #endregion

            #endregion

        }
    }
}
