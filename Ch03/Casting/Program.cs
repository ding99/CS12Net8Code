using static System.Convert;
using System.Globalization;

System.Console.WriteLine("{0,12} {1,34}", "Decimal", "Binary");
System.Console.WriteLine("{0,12} {0,34:B32}", int.MaxValue);
for (int i = 4; i >= -4; i--){
    System.Console.WriteLine("{0,12} {0,34:B32}", i);
}
System.Console.WriteLine("{0,12} {0,34:B32}", int.MinValue);

Console.ForegroundColor = ConsoleColor.Cyan;
double g = 9.8;
int h = ToInt32(g);
System.Console.WriteLine($"g is {g}, h is {h}");

Console.ForegroundColor = ConsoleColor.Yellow;

string dt1 = "5 June 1999";
string dt2 = "5a June 19929";
System.Console.WriteLine($"{dt1} : {DateTime.TryParse(dt1, out DateTime d1)} [{d1}]");
System.Console.WriteLine($"{dt2} : {DateTime.TryParse(dt2, out DateTime d2)} [{d2}]");

Console.ResetColor();
