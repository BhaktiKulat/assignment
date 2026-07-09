/*A smart city has 30 street lights numbered 1 to 30. The power consumption (in watts) for each light is calculated using the formula:
Power = 80 + (Light Number × 5)
For each street light:
‌If power consumption is greater than 180 W, display "Maintenance Required".
‌Else if power consumption is between 140 W and 180 W, display "Normal Operation".
‌Otherwise, display "Energy Efficient".
Also calculate and display:
‌Total power consumed by all street lights
‌Average power consumption
‌Number of lights in each category*/

using System;

class assignment
{
    static void Main()
    {
        int totalPower = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        Console.WriteLine("Street Light Power Monitoring\n");

        // Street lights numbered 1 to 30
        for (int light = 1; light <= 30; light++)
        {
            int power = 80 + (light * 5);
            totalPower += power;

            if (power > 180)
            {
                Console.WriteLine("Light " + light + " -> " + power + " W : Maintenance Required");
                maintenance++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Light " + light + " -> " + power + " W : Normal Operation");
                normal++;
            }
            else
            {
                Console.WriteLine("Light " + light + " -> " + power + " W : Energy Efficient");
                efficient++;
            }
        }

        double averagePower = (double)totalPower / 30;

        Console.WriteLine("Total Power Consumed : " + totalPower + " W");
        Console.WriteLine("Average Power Consumption : " + averagePower + " W");
        Console.WriteLine("Maintenance Required : " + maintenance);
        Console.WriteLine("Normal Operation : " + normal);
        Console.WriteLine("Energy Efficient : " + efficient);
    }
}