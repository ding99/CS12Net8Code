using System.ComponentModel;

Write("Enter a number:");
string number = ReadLine()!;
double a = double.Parse(number);
double b = 2.5;
double answer = Add(a, b);
WriteLine($"{a} + {b} = {answer}");

static double Add(double a, double b) {
    return a + b;
}