using System.Numerics;

Console.WriteLine("## Arithmetic operators ##");

Console.WriteLine("Enter an X value");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an y value");
int y = Convert.ToInt32(Console.ReadLine());

double division = (double) x / y;

Console.WriteLine($"Sum Of x + y ={x + y}");
Console.WriteLine($"Subtraction of x - y = {x - y}");
Console.WriteLine($"Multiplication of x * y = {x * y}");
Console.WriteLine($"Division of x / y = {division}");
Console.WriteLine($"Module of x % y = {x % y}");

Console.WriteLine($"Square root of x = {Math.Sqrt}");
Console.WriteLine($"x to the power of y = {Math.Pow(x,y)}");
Console.WriteLine($"Minimal value between x and y = {Math.Min(x, y)}");
Console.WriteLine($"Maximum value between x and y = {Math.Max(x,y)}");
Console.WriteLine($"Cosine of x = {Math.Cos(x)}");
Console.WriteLine($"Sine of x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial of x = {Math.Exp(x)}");
