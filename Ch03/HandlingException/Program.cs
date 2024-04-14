int x = int.MaxValue - 1;
System.Console.WriteLine($"Initial value: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");
x++;
System.Console.WriteLine($"After incrementing: {x}");

try {
    checked{
        x = int.MaxValue - 1;
        System.Console.WriteLine($"Initial value: {x}");
        x++;
        System.Console.WriteLine($"After incrementing: {x}");
        x++;
        System.Console.WriteLine($"After incrementing: {x}");
        x++;
        System.Console.WriteLine($"After incrementing: {x}");
    }
}
catch(OverflowException){
    System.Console.WriteLine("The code overflowed but I caught the exception.");
}

unchecked {
int y = int.MaxValue + 1;
System.Console.WriteLine($"Initial value: {y}");
y--;
System.Console.WriteLine($"After decrementing: {y}");
y--;
System.Console.WriteLine($"After decrementing: {y}");
}
