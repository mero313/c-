using System;




/* Each shipment must have unique id
 
The shipment order is on a list 
The program must recursivley go through each shipment
Creating new object is loading the shipment
displaying the obejcts is unloading



 
Steps:
create array of shipment objects
for loop that read the content of the objects
after we fill the array with objects
use recursion to do the unloading process
finish
*/





namespace Program {
    class Shipment {
        public int shipmentID;
        public string shipmentContent;
        public static int shipmentsCount = 0;
        public Shipment(string content) {
            shipmentID = ++shipmentsCount;
            shipmentContent = content;
        }
    }

    class MainProgram {
        public static void PrintInRecusirve(Shipment[] arr, int counter = 0) {
            // base case: if the counter is bigger
            // than the length of the array
            if (counter > arr.Length - 1)
                return;

            // recurive call to the func
            PrintInRecusirve(arr, counter + 1);

            // This will work after the recursion is over
            Console.WriteLine(arr[counter].shipmentID);
            Console.WriteLine(arr[counter].shipmentContent);
        }
        public static void Main(string[] args) {
            Shipment[] shipmentsArr = new Shipment[5];
            Console.WriteLine("Loading Process: ");
            for (int i = 0; i < 5; i++) {
                string value = Console.ReadLine();
                shipmentsArr[i] = new Shipment(value);
            }

            Console.WriteLine("Unloading process: ");
            PrintInRecusirve(shipmentsArr);

        }
    }
}