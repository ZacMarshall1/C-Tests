Console.WriteLine("## Switch Case Test ##");

double price = 600.00;

Console.WriteLine($"Purchase Value: ${price}");
Console.WriteLine("Enter the number of installments (1 to 3):");
int installmentNumber = Convert.ToInt32(Console.ReadLine());

switch (installmentNumber)
{
    case 1:
        Console.WriteLine("Single payment.");
        break;

    case 2:
    case 3:
        double installmentValue = price / installmentNumber;
        Console.WriteLine($"{installmentNumber} installment(s) of ${installmentValue:F2} each.");
        break;

    default:
        Console.WriteLine("Invalid payment method.");
        break;
}