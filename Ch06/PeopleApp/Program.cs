using Packt.Shared;
Person harry = new() {
    Name = "Harry",
    Born = new(2002, 3, 25, 0, 0, 0, TimeSpan.Zero)
};
harry.WriteToConsole();
