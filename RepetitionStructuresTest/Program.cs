Console.WriteLine("## Repetition Structures ##");

//goto (not recommended)
int i = 1;
double input  = Convert.ToDouble(Console.ReadLine());

//repeat:

//    Console.WriteLine($"i= {i}");

//    i++;

//if (i < 10)
//    goto repeat;

while (i <= 10)
{
    double result = input * i;
    Console.WriteLine($"{input} * {i} = {result}");
    i++;
}

Console.WriteLine("End of process...");
