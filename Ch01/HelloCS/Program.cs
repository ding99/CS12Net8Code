// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, CSharp!");
var name = typeof(Program).Namespace ?? "None!";
Console.WriteLine($"Namespace: {name}");
Console.ForegroundColor = ConsoleColor.Yellow;
int z = 15;
System.Console.WriteLine($"org: [{z}], clamp(2,8): [{int.Clamp(z, 2, 8)}]");

string a = "15", b = "1a";
var a1 = int.Parse(a);
System.Console.WriteLine($"a [{a}], parsed [{a1}]");
var b1 = int.TryParse(b, out int c1);
System.Console.WriteLine($"a [{b}], parsed [{b1}], c [{c1}]");
var b2 = int.TryParse(b, System.Globalization.NumberStyles.HexNumber, null, out int c2);
System.Console.WriteLine($"a [{b}], parsed [{b2}], c [{c2}]");