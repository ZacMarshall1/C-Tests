Console.WriteLine(" ## Constants ##");

const int YEAR = 12;

const int MONTH = 30, WEEK = 7, FORTNIGHT = 14;

const int MONTHS_YEAR = 12;
const int DAYS_YEAR = 365;

const float DAYS_PER_MONTH = (float)DAYS_YEAR / (float)MONTHS_YEAR;

double radius = Convert.ToDouble(Console.ReadLine());
double perimeter;
double area;

const double PI = Math.PI;

perimeter = PI * 2 * radius;
area = PI * Math.Pow(radius, 2);

Console.WriteLine($"perimiter = {perimeter}, area = {area}");