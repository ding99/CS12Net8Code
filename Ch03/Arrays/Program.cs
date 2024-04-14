int[] sequentialNumbers = {1,2,3,4,5,6,7,8,9,10};
int[] oneTwoNumbers = {1,2};
int[] oneTwoTenNumbers = {1,2,10};
int[] oneTwoThreeTenNumbers = {1,2,3,10};
int[] primeNumbers = {2,3,5,7,11,13,17,19,23,29};
int[] fibonacciNumbers = {0,1,1,2,3,5,8,13,21,34,55,89};
int[] emptyNumbers = {}; // Array.Empty<int>()
int[] threeNumbers = {9,7,5};
int[] sixMumbers = {9,7,5,4,2,10};

System.Console.WriteLine($"{nameof(sequentialNumbers)}:{CheckSwitch(sequentialNumbers)}");
System.Console.WriteLine($"{nameof(oneTwoNumbers)}:{CheckSwitch(oneTwoNumbers)}");
System.Console.WriteLine($"{nameof(oneTwoTenNumbers)}:{CheckSwitch(oneTwoTenNumbers)}");
System.Console.WriteLine($"{nameof(oneTwoThreeTenNumbers)}:{CheckSwitch(oneTwoThreeTenNumbers)}");
System.Console.WriteLine($"{nameof(primeNumbers)}:{CheckSwitch(primeNumbers)}");
System.Console.WriteLine($"{nameof(fibonacciNumbers)}:{CheckSwitch(fibonacciNumbers)}");
System.Console.WriteLine($"{nameof(emptyNumbers)}:{CheckSwitch(emptyNumbers)}");
System.Console.WriteLine($"{nameof(threeNumbers)}:{CheckSwitch(threeNumbers)}");
System.Console.WriteLine($"{nameof(sixMumbers)}:{CheckSwitch(sixMumbers)}");

static string CheckSwitch(int[] values) => values switch{
    [] => "Empty array",
    [1,2,_,10] => "Contains 1, 2, any single number, 10.",
    [1,2,..,10] => "Contains 1, 2, any range including empty, 10.",
    [1,2] => "Contains 1 then 2.",
    [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
    [0,_] => "Starts with 0, then one of other number.",
    [0,..] => "Starts with 0, then any range of numbers.",
    [2,..int[] others] => $"Starts with 2, then {others.Length} more numbers.",
    [..] => "Any items in any order.",
};
