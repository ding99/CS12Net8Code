//TimesTable(7, 15);

ConfigureConsole("fr-FR");
decimal taxToPay = CalculateTax(149, "FR");
System.Console.WriteLine($"You much pay {taxToPay:C} in tax.");