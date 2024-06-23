using Packt.Shared;

ForegroundColor = ConsoleColor.Green;
Person harry = new() {
    Name = "Harry",
    Born = new(2002, 3, 25, 0, 0, 0, TimeSpan.Zero)
};
harry.WriteToConsole();

ForegroundColor = ConsoleColor.Yellow;
Person lamech = new() { Name = "Lamech" };
Person adah = new(){Name="Adah"};
Person zillah = new() { Name="Zillah"};
lamech.Marry(adah);
// Person.Marry(lamech, zillah);
if(lamech + zillah){
    WriteLine($"{lamech.Name} and {zillah.Name} successfully got merried.");
}
lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";
Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();
for(int i = 0; i<lamech.Children.Count;i++){
    WriteLine(" {0}'s child #{1} is named \"{2}\".",
    lamech.Name, i,
    lamech.Children[i].Name);
}

ResetColor();