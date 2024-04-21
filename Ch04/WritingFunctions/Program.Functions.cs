using System.Globalization;

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

    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false){
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture){
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        System.Console.WriteLine($"CurrentCulture:{CultureInfo.CurrentCulture.DisplayName}");
    }

    static decimal CalculateTax(decimal amount, string regionCode){
        decimal rate = regionCode switch{
            "CH" => .08M, //Switzerland
            "DK" or "NO" =>.25M, //Denmark, Norway
            "GB" or "FR" => .2M, //UK, France
            "HU" => .27M, //Hungary
            "OR" or "AK" or "MT" => .0M, //Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => .05M,
            _ => .06M // Most other states
        };
        return amount * rate; 
    }

}
