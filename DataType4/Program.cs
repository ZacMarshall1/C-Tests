using System.Runtime.CompilerServices;

Console.WriteLine("Assigning variables string, object & dynamic");
Console.WriteLine();

string name = "CStests";
string title = "Title";

Console.WriteLine(name);
Console.WriteLine(title);

string value = "This is a string";
value = "This is an altered sting";

Console.WriteLine(value);

object grade = 10;
object value1 = 8.55m;
object name1 = "Name";
object active = true;
object letter = 'A';

Console.WriteLine(grade);
Console.WriteLine(value1);
Console.WriteLine(name1);
Console.WriteLine(active);
Console.WriteLine(letter);




dynamic grade2 = 10;
dynamic value2 = 8.55m;
dynamic name2 = "Name";
dynamic active2 = true;
dynamic letter2 = 'A';

Console.WriteLine(grade2);
Console.WriteLine(value2);
Console.WriteLine(name2);
Console.WriteLine(active2);
Console.WriteLine(letter2);

Console.ReadLine();