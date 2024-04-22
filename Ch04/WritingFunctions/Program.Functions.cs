using System.Globalization;
using System.Security.Cryptography;

partial class Program
{

    static void TimesTable(byte number, byte size = 12) {
        Console.WriteLine($"This is the {number} times table with {size} rows:");
        System.Console.WriteLine();
        for (int row = 1; row <= size; row++) {
            System.Console.WriteLine($"{row} x {number} = {row * number}");
        }
        System.Console.WriteLine();
    }

    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false) {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture) {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        System.Console.WriteLine($"CurrentCulture:{CultureInfo.CurrentCulture.DisplayName}");
    }

    /// <summary>
    /// Calculate tax
    /// </summary>
    /// <param name="amount">price</param>
    /// <param name="regionCode">region code</param>
    /// <returns>tax/returns>
    static decimal CalculateTax(decimal amount, string regionCode) {
        decimal rate = regionCode switch {
            "CH" => .08M, //Switzerland
            "DK" or "NO" => .25M, //Denmark, Norway
            "GB" or "FR" => .2M, //UK, France
            "HU" => .27M, //Hungary
            "OR" or "AK" or "MT" => .0M, //Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => .05M,
            _ => .06M // Most other states
        };
        return amount * rate;
    }

    static string CardinalToOrdinal(uint number){
        uint lastTwoDigits = number % 100;
        switch(lastTwoDigits) {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
                default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }

    static int FibImperative(uint term){
        if(term == 0){
            throw new ArgumentOutOfRangeException();
        }
        else if(term == 1){
            return 1;
        }else if(term == 2){
            return 1;
        } else{
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }

}
