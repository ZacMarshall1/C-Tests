Console.WriteLine("## Unary And Ternary Operators ##");

Console.WriteLine("Informe um número: \n");

int n = Convert.ToInt32(Console.ReadLine());
string? greaterOrLower = n > 50 ? "is greater than " : 
                         n < 50 ? "is lower than " : 
                         n == 50 ? "is equal to " : "No Valid Answer";

Console.WriteLine($"The negative version of {n} is : {-n}");

Console.WriteLine($"{n} {greaterOrLower}50");