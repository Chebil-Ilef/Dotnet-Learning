// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine(now);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
Console.WriteLine(today);

// TODO: DateOnly and TimeOnly represent just dates and times
DateOnly dateOnly = new DateOnly(2023, 8, 6);
TimeOnly timeOnly = new TimeOnly(12, 30, 0);
Console.WriteLine(dateOnly);
Console.WriteLine(timeOnly);

DateOnly dateOnly1 = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timeOnly1 = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(dateOnly);
Console.WriteLine(timeOnly);

// TODO: Dates have properties that can be inspected
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);

// TODO: Dates also have methods to change their values
now = now.AddDays(2);
now = now.AddMonths(1);
now = now.AddYears(4);
now = now.AddHours(8);
Console.WriteLine(now);

// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);

TimeSpan interval = AprilFools - NewYears;
Console.WriteLine(interval);


// TODO: Dates can be compared using regular operators
Console.WriteLine(AprilFools > NewYears);
Console.WriteLine(AprilFools < NewYears);