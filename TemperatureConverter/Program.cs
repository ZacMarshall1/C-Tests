Console.WriteLine("## Temperature Converter ##");

Console.WriteLine("Enter a temperature in celcius");

double celcius = Convert.ToDouble(Console.ReadLine());
double kelvin = celcius + 273;
double farhenheit = (celcius * 9) / 5 + 32;

Console.WriteLine($"Celcius temperature: {celcius}");
Console.WriteLine($"Kelvin temperature: {kelvin}");
Console.WriteLine($"Farhenheit temperature: {farhenheit}");

