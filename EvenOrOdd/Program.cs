Console.WriteLine("## Guessing even or odd numbers ##");

Console.WriteLine("Enter an integer Number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another integer number:");
int y = Convert.ToInt32(Console.ReadLine());

string isOddx = (x % 2 == 0) ? "Even" : "Odd";
string isOddy = (y % 2 == 0) ? "Even" : "Odd";

Console.WriteLine($"{x} is an {isOddx} number!");
Console.WriteLine($"{y} is an {isOddy} number!");