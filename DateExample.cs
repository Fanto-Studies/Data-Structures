// Documentation: https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0

using System;

// DateTime(Year, Month, Day, Hour, Minutes, Seconds)
Console.WriteLine("Testing the DateTime manual configurarion");
var manualDateTime = new DateTime(2025,4,11,12,49,0);
Console.WriteLine($"The manual time gived is: {manualDateTime.ToString()}");

// Accessing the values separated
Console.WriteLine("\nGetting the specific parts from the DateTime: \n");
Console.WriteLine($"The Year from the DateTime: {manualDateTime.Year}");
Console.WriteLine($"The Month from the DateTime: {manualDateTime.Month}");
Console.WriteLine($"The Day from the DateTime: {manualDateTime.Day}");
Console.WriteLine($"The Hour from the DateTime: {manualDateTime.Hour}");
Console.WriteLine($"The Minute from the DateTime: {manualDateTime.Minute}");
Console.WriteLine($"The Seconds from the DateTime: {manualDateTime.Second}");

// Get current local time
Console.WriteLine("\nGetting the current local time: \n");
Console.WriteLine($"Local DateTime this moment: {DateTime.Now}");

// Configure the exit from the DateTime
Console.WriteLine("\nCheck Different outcomes from DateTime: \n");
var checkDate = DateTime.Now;
Console.WriteLine($"Getting the date pattern as Month/Day/Year: {checkDate.ToString("d")}");
Console.WriteLine($"Getting the date pattern as Week, Month Day, Year: {checkDate.ToString("D")}");
Console.WriteLine($"Getting the date from Brazil pattern: {DateTime.Now.ToString("dd/MM/yyyy")}");

// Get Timezone information
Console.WriteLine("\nChecking the TimeZone and DateTime from Different places: \n");
var saoPauloBrazil = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
var austinTexas = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
DateTime saoPauloTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, saoPauloBrazil);
DateTime austinTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, austinTexas);
Console.WriteLine($"UTC time: {DateTime.UtcNow}");
Console.WriteLine($"Sao Paulo - Brazil: {saoPauloTime.ToString("G")}");
Console.WriteLine($"Austin - Texas: {austinTime.ToString("G")}");

// Check time interval between two dates
Console.WriteLine("\nCheck interval between two dates!\n");
var dt1 = new DateTime(1996,4,26);
var dt2 = DateTime.Now;
var interval = dt2.Subtract(dt1);
var age = dt2.Year - dt1.Year;
Console.WriteLine($"John born at {dt1.ToString("d")}");
Console.WriteLine($"Today is {dt2.ToString("d")}");
Console.WriteLine($"John is alive for {interval.Days} Days");
Console.WriteLine($"John is {age} years old");
