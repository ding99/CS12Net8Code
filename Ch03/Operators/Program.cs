#region unary

int a = 3;
int b = a++;
System.Console.WriteLine($"(b=a++) : a is {a}, b is {b}");

int c = 3;
int d= ++c;
System.Console.WriteLine($"(d=++c) : c is {c}, d is {d}");

#endregion

#region bitwise

Console.ForegroundColor = ConsoleColor.Yellow;
int x = 10, y = 6;
System.Console.WriteLine($"Expression|Decimal|Binary");
System.Console.WriteLine("-------------------------");
System.Console.WriteLine($"x       |{x,7}|{x:B8}");
System.Console.WriteLine($"y       |{y,7}|{y:B8}");
System.Console.WriteLine($"x<<3    |{x<<3,7}|{x<<3:B8}");
System.Console.WriteLine($"x*8     |{x* 8,7}|{x*8:B8}");
System.Console.WriteLine($"y>>1    |{y>>1,7}|{y>>1:B8}");
Console.ResetColor();

#endregion

System.Console.WriteLine($"The {nameof(x)} variable uses {sizeof(int)} bytes of memory.");