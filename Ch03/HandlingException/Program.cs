int x = int.MaxValue - 1;
System.Console.WriteLine($"Initial value: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");

checked {
x = int.MaxValue - 1;
System.Console.WriteLine($"Initial value: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");
}
