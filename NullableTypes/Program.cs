Console.WriteLine("## Nullable Types ## \n");

Nullable<int> i = null;
Nullable<double> d = null;
bool? b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

int? a = null;

//null coalescence operator to prevent errors
int c = a ?? 0;

//in case of operations with nullable variables, all variables involved have to be null
int? x = 4;
int? y = 5;
int? z = x * y;

//HasValue evaluates if the parameter has a valua assigneed

int? hasValueTest = 100;

if (hasValueTest.HasValue)
{
    Console.WriteLine($"b={hasValueTest.Value}");
}
else
{
    Console.WriteLine("Value not assigned");
};

    Console.WriteLine(c);

Console.WriteLine(z);

Console.ReadLine();