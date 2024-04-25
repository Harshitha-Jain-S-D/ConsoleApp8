using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Input hour and minute separated by space (e.g., 9 30): ");
        string[] timeInput = Console.ReadLine().Split(' ');
        int hour = int.Parse(timeInput[0]);
        int minute = int.Parse(timeInput[1]);

        double angle = CalculateClockAngle(hour, minute);

        Console.WriteLine("The angle between hour hand and minute hand is " + angle + " degrees");
    }

    static double CalculateClockAngle(int hour, int minute)
    {
        // Convert 12-hour clock to 24-hour clock
        hour %= 12;

        // Calculate the angle made by hour hand with respect to 12 o'clock position
        double hourAngle = (hour * 30) + (minute * 0.5); // 30 degrees per hour, 0.5 degrees per minute

        // Calculate the angle made by minute hand with respect to 12 o'clock position
        double minuteAngle = minute * 6; // 6 degrees per minute

        // Find the difference between the two angles
        double angle = Math.Abs(hourAngle - minuteAngle);

        // Ensure the smaller angle is used (e.g., 30 degrees instead of 330 degrees)
        angle = Math.Min(360 - angle, angle);

        return angle;
    }
}