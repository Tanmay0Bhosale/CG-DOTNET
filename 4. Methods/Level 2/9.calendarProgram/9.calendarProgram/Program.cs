using System;

class CalendarProgram
{
    static string GetMonthName(int month)
    {
        string[] months = {
            "January","February","March","April","May","June",
            "July","August","September","October","November","December"
        };
        return months[month - 1];
    }

    static bool IsLeapYear(int year)
    {
        if (year < 1582) return false;
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
            return 29;
        return days[month - 1];
    }

    static int GetFirstDay(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;
        return d0;
    }

    static void DisplayCalendar(int month, int year)
    {
        Console.WriteLine("\n   " + GetMonthName(month) + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDay(month, year);
        int days = GetDaysInMonth(month, year);

        // First loop → indentation
        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        // Second loop → print days
        for (int day = 1; day <= days; day++)
        {
            Console.Write($"{day,3} ");

            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}
