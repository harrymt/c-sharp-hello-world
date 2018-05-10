using System;

class DateTimes
{
    public DateTimes()
    {
        DefineTimes();
    }

    void DefineTimes()
    {
        DateTime currentTime = DateTime.Now;
        DateTime todaysDate = DateTime.Today;
        DateTime birthday = new DateTime(1993, 11, 16);
        DateTime tomorrow = DateTime.Today.AddDays(1);
        DateTime parsed = DateTime.Parse("2018/11/12");
    }
}
