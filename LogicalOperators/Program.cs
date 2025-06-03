Console.WriteLine("## Logical Operators ##");

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool result;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

result = c1 && c2;
Console.WriteLine($"And Operator Result {result}");

result = c1 || c2;
Console.WriteLine($"Or Operator Result {result}");

result = !(c1 && c2);
Console.WriteLine($"Not Operator Result {result}");
