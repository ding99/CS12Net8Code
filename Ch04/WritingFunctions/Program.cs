//TimesTable(7, 15);

// ConfigureConsole("fr-FR");
// decimal taxToPay = CalculateTax(49, "FR");
// WriteLine($"You much pay {taxToPay:C} in tax.");

RunFibImperative();

static void RunFibImperative(){
    for (uint i = 1; i <= 30;i++){
        System.Console.WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
        arg0:CardinalToOrdinal(i),
        arg1:FibImperative(term:i));
    }
}
