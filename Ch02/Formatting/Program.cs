using static System.Console;

int numberOfApples = 12;
decimal price = 0.45M;
WriteLine(
    format:"{0} apples cost {1:C}",
    arg0:numberOfApples,
    arg1:price * numberOfApples);
string formatted = string.Format(
    format:"{0} apples cost {1:C}",
    arg0:numberOfApples,
    arg1: price * numberOfApples);
WriteLine(formatted);
