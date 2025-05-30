using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Data output Formatting: ");

int age = 25;
string name = "Maria";
//Concatenation
Console.WriteLine(name + " is " + age + " years old");
//interpolation
Console.WriteLine($"{name} is {age} years old");
//placeHolders
Console.WriteLine("{0} is {1} years old", name , age);

Console.ReadLine();