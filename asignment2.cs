/*An automated conveyor belt processes 20 packages. Package IDs are generated from 1001 to 1020 using a loop.

For each package:

If the package ID is divisible by 4, it is marked as Quality Check Required.

Else if the package ID is divisible by 5, it is marked as Priority Shipment.

Otherwise, it is marked as Normal Processing.

At the end of the program, display:

Total packages processed

Number of packages requiring quality check

Number of priority shipments

Number of normal packages*/

using System;

class asignment2
{
    static void Main()
    {
        int totalPackages = 20;
        int qualityCheck = 0;
        int priorityShipment = 0;
        int normalProcessing = 0;

        Console.WriteLine("Package Processing System\n");

        // Generate Package IDs from 1001 to 1020
        for (int packageID = 1001; packageID <= 1020; packageID++)
        {
            if (packageID % 4 == 0)
            {
                Console.WriteLine("Package ID: " + packageID + " -> Quality Check Required");
                qualityCheck++;
            }
            else if (packageID % 5 == 0)
            {
                Console.WriteLine("Package ID: " + packageID + " -> Priority Shipment");
                priorityShipment++;
            }
            else
            {
                Console.WriteLine("Package ID: " + packageID + " -> Normal Processing");
                normalProcessing++;
            }
        }

    
        Console.WriteLine("Total Packages Processed : " + totalPackages);
        Console.WriteLine("Quality Check Required   : " + qualityCheck);
        Console.WriteLine("Priority Shipments       : " + priorityShipment);
        Console.WriteLine("Normal Processing        : " + normalProcessing);
    }
}

