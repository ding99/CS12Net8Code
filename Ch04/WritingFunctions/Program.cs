//TimesTable(7, 15);

ConfigureConsole("fr-FR");
decimal taxToPay = CalculateTax(49, "FR");
WriteLine($"You much pay {taxToPay:C} in tax.");