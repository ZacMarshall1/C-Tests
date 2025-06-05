Console.WriteLine("## Exercises 1 ##");

string name = "Paul";
int age = 17;
float grade = 7.5f;

Console.WriteLine($"Student:{name}, is {age} years old and a score of {grade}");
Console.WriteLine($"{name}\n{age}\n{grade}");

string? myInput = Console.ReadLine();

char letterOne = myInput[0];

myInput = Console.ReadLine();

char letterTwo = myInput[0];

myInput = Console.ReadLine();

char letterThree = myInput[0];

myInput = null;

Console.WriteLine($"Letter three: {letterThree}\nletter two: {letterTwo}\nletter one: {letterOne}");

double value1 = Convert.ToDouble(Console.ReadLine());
double value2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Sum: {value1 + value2}");
Console.WriteLine($"Subtraction: {value1 - value2}");
Console.WriteLine($"Division: {value1 / value2}");
Console.WriteLine($"Multiplication: {value1 * value2}");

