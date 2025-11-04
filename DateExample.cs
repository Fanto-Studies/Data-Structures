// Documentation: https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0

using System;

// DateTime(Year, Month, Day, Hour, Minutes, Seconds)
Console.WriteLine("Testing the DateTime manual configurarion");
var manualDateTime = new DateTime(2025,4,11,12,49,0);
Console.WriteLine($"The manual time gived is: {manualDateTime.ToString()}");

