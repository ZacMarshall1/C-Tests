using System.ComponentModel.DataAnnotations;

Console.WriteLine("## If statement ##");

Console.WriteLine("Special client (true/false)");
bool isSpecial = Convert.ToBoolean(Console.ReadLine());

if(isSpecial)
{
    Console.WriteLine("10% discount");
}
Console.WriteLine("End of program");

Console.WriteLine("Enter an x value: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an y value:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X is greater than Y");
}
else if(x == y)
{
    Console.WriteLine("X is equal to Y");
}
else
{
    Console.WriteLine("Y is greater than X");
}