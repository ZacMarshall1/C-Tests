Console.WriteLine("## Type Conversion ##\n");

int intValue = 123;
double doubleValue = 12.45;
decimal decimalValue = 12.45678m;

string s1 = intValue.ToString();
string s2 = doubleValue.ToString();
string s3 = decimalValue.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

int intValue2 = 10;
double doubleValue2 = 5.35;
bool boolValue2 = true;

Console.WriteLine(Convert.ToString(intValue2));
Console.WriteLine(Convert.ToDouble(intValue2));
Console.WriteLine(Convert.ToString(boolValue2));
Console.WriteLine(Convert.ToInt32(doubleValue2));


/*
    ///this line shows how the Convert Function when there is no shortening on the value, and doesn't show errors,
    ///but if the values exceed the number of bits, it will crash
    int intValue3 = 100000;
    Console.WriteLine(Convert.ToByte(intValue3));
*/

Console.ReadLine();
