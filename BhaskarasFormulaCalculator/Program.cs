Console.WriteLine("## Bhaskara's formula ##");

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double delta = Math.Pow(b, 2) - 4 * a * c;

if (delta < 0)
{
    Console.WriteLine("No real roots (delta is negative).");
}
else
{
    double resultOne = (-b + Math.Sqrt(delta)) / (2 * a);
    double resultTwo = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine($"Delta = {delta}");
    Console.WriteLine($"Root 1: {resultOne}");
    Console.WriteLine($"Root 2: {resultTwo}");
}