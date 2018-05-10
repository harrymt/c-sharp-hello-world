using System;

class DateTimes
{
    public DateTimes()
    {
        DefineTimes();
        PartsOfDateTime();
        CalculateDifferences();
    }

    void DefineTimes()
    {
        DateTime currentTime = DateTime.Now;
        DateTime todaysDate = DateTime.Today;
        DateTime birthday = new DateTime(1993, 11, 16);
        DateTime tomorrow = DateTime.Today.AddDays(1);
        DateTime parsed = DateTime.Parse("2018/11/12");
    }

    void PartsOfDateTime()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"It is the year {now.Year}");
        Console.WriteLine($"What a month {now.Month}");
        Console.WriteLine($"To be alive {now.Day}");
        Console.WriteLine($"At this time {now.Hour} {now.Minute} {now.Second}");
    }

    void CalculateDifferences()
    {
        DateTime tomorrow = DateTime.Today.AddDays(1);
        DateTime today = DateTime.Today;
        TimeSpan difference = today - tomorrow;
        Console.WriteLine($"The difference between today and tomorrow is {difference.TotalDays} day.");
    }
}
