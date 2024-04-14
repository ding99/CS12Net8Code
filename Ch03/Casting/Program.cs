System.Console.WriteLine("{0,12} {1,34}", "Decimal", "Binary");
System.Console.WriteLine("{0,12} {0,34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--){
    System.Console.WriteLine("{0,12} {0,34:B32}", i);
}
System.Console.WriteLine("{0,12} {0,34:B32}", int.MinValue);

