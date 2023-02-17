using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calendar Program");

        // Get year and month from user
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter a month: ");
        int month = int.Parse(Console.ReadLine());

        // Calculate the number of days in the month
        int daysInMonth = DateTime.DaysInMonth(year, month);

        // Calculate the day of the week that the month starts on
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        DayOfWeek dayOfWeek = firstDayOfMonth.DayOfWeek;

        // Print the calendar
        Console.WriteLine("{0} {1}", firstDayOfMonth.ToString("MMMM"), year);
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // Print leading spaces for the first week
        for (int i = 0; i < (int)dayOfWeek; i++)
        {
            Console.Write("   ");
        }

        // Print the days of the month
        for (int i = 1; i <= daysInMonth; i++)
        {
            Console.Write("{0,2} ", i);

            // Add a newline after Saturday
            if (dayOfWeek == DayOfWeek.Saturday && i < daysInMonth)
            {
                Console.WriteLine();
            }

            // Move to the next day of the week
            dayOfWeek = dayOfWeek == DayOfWeek.Saturday ? DayOfWeek.Sunday : dayOfWeek + 1;
        }

        Console.ReadLine();
    }
}
