using Packt.Shared;

ConfigureConsole();
Person bob = new();
WriteLine(bob);

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22, hour: 14, minute: 28, second: 0, offset: TimeSpan.FromHours(-5));
WriteLine(format: "{0} was born on {1:D} ({1:d}).", bob.Name, bob.Born);
