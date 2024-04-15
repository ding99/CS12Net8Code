partial class Program
{

    static void TimesTable(byte number, byte size=12){
        Console.WriteLine($"This is the {number} times table with {size} rows:");
        System.Console.WriteLine();
        for(int row = 1; row <=size; row++){
            System.Console.WriteLine($"{row} x {number} = {row*number}");
        }
        System.Console.WriteLine();
    }

}
