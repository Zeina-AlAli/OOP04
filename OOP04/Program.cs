namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 :
            //// a.What is Abstraction?
            //Console.WriteLine("Abstraction: is the process of hiding the implementation details and showing only the essential features to the user ");

            //// b.Why abstraction is considered one of the 4 pillars
            //Console.WriteLine("because it reduce complexity, improves maintainability, enhance security, and promote flexibility ");

            #endregion

            #region Q2 :
            //// a. Abstract vs interface class
            //Console.WriteLine("Abstract class can have: absract (unimplemented) and concrete methods, fields, constructor,and can use any access modifier. in addition, class can inherit one abstract class \nwhile interface have only abstract methods, cant have fields or constructor, members are public by default. classes can implement multiple interface.");

            //// b. Choose interface instead od abstract class
            //Console.WriteLine("When you want to define a concract that unrelated classes can implement, without sharing common implentation ");

            //// c. multiple inheritance
            //Console.WriteLine("Classes cant inherit multiple abstract classes, but can implement multiple interface");
            #endregion

            #region Part2 

            //Console.WriteLine("\nDelivery Center");
            //Console.WriteLine("=========================================================================\n");

            //// a. Create Shipments
            //DeliveryAddress des = new DeliveryAddress();
            //StandardShipment st = new StandardShipment("SH001", "Laptop", 3.0, 3.0m, des);

            //ExpressShipment ex = new ExpressShipment("SH002", "Phone", 3.0, 3.0m, des, 2.0m);

            //InternationalShipment i = new InternationalShipment("Cairo", 2.0m, "SH003", "Ipad", 3.0, 3.0m, des);

            //// b. Add shipments 
            //DeliveryCenter dc = new DeliveryCenter();
            //dc.AddShipment(st);
            //dc.AddShipment(ex);
            //dc.AddShipment(i);

            //// c. Print Shipments
            //dc.PrintAllShipments();

            //// d. Print Tracking status
            //Console.WriteLine("Tracking Status:\n");
            //dc.PrintTrackingStatuses();

            //Console.WriteLine("=========================================================================");

            //// e. Printg Insurance Cost
            //Console.WriteLine("Insurance Cost\n");
            //dc.PrintInsuranceCost();
            //Console.WriteLine("=========================================================================\n");

            //// h. Store shipment in ITrackable array
            //ITrackable[] arr = new ITrackable[3];
            //arr[0] = st;
            //arr[1] = ex;
            //arr[2] = i;

            ////print tracking status
            //foreach (ITrackable t in arr)
            //{
            //    if (t != null)
            //        Console.WriteLine(t.GetTrackingStatus());
            //}

            //// i. Store shipments in IInsurable array
            //IInsurable[] arr2 = new IInsurable[3];
            //arr2[0] = st;
            //arr2[1] = ex;
            //arr2[2] = i;
            //Console.WriteLine("\n=========================================================================\n");
            ////print isurance cost
            //foreach (IInsurable ins in arr2)
            //{
            //    if (ins != null)
            //        Console.WriteLine(ins.CalculateInsurance());



            //}
            #endregion
        }
    }
}
