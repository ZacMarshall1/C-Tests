Console.WriteLine("## Sruct DateTime## \n");

DateTime CurrentDate = DateTime.Now;
Console.WriteLine($"Today: {CurrentDate}\n");
//Extracting specific information about the present day
Console.WriteLine(CurrentDate.Year);
Console.WriteLine(CurrentDate.Month);
Console.WriteLine(CurrentDate.Day);
Console.WriteLine(CurrentDate.Hour);
Console.WriteLine(CurrentDate.Minute);
Console.WriteLine(CurrentDate.Millisecond);

//Adding values to the present time
Console.WriteLine(CurrentDate.AddDays(30));
Console.WriteLine(CurrentDate.AddMonths(1));
Console.WriteLine(CurrentDate.AddHours(2));
Console.WriteLine(CurrentDate.AddYears(5));

//Getting day of the week and day of year
Console.WriteLine(CurrentDate.DayOfWeek);
Console.WriteLine(CurrentDate.DayOfYear);

//Long and short format
Console.WriteLine(CurrentDate.ToLongDateString());
Console.WriteLine(CurrentDate.ToShortDateString());

Console.WriteLine(CurrentDate.ToLongTimeString());
Console.WriteLine(CurrentDate.ToShortTimeString());

//How to create an specific date and time using format using japanese standards aaa,mm,dd

DateTime todayDate = new DateTime(2025, 05, 30);
Console.WriteLine(todayDate);

//Assigning present time values
DateTime todaysTime = new DateTime(2025, 05, 30, 09, 10, 40);
Console.WriteLine(todaysTime);

Console.ReadLine();
