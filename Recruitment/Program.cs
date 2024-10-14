// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
List<string> NamesRecrutable = ["Jacob", "Viggo", "Moa", "Lukas", "Felix", "Oskar", "Nora", "Alice"];
List<string> Recruited = [];
int vald = 0;
System.Console.WriteLine("du ska recrytera spealre för ditt Fotbolls lag du får välja 3 spelare och du får välja mellan dessa spelare. Skriv vilket nummer dom har");
for (int k = 0; k < 3; k++)
{   
    System.Console.WriteLine("spelare "+ k);
    for (int i = 0; i < NamesRecrutable.Count; i++)
    {
        System.Console.WriteLine(NamesRecrutable[i]);
    }
        bool success = false;
        while (success == false || vald < 1 || vald > NamesRecrutable.Count)
        {
            string spelarevald = Console.ReadLine();
            success = int.TryParse(spelarevald, out vald);
        }
        Recruited.Add(NamesRecrutable[vald-1]);
        NamesRecrutable.RemoveAt(vald - 1);
            System.Console.WriteLine("Du har rekryterat:");
        Console.Clear();
        System.Console.WriteLine("du har dessa spelare:");
        for (int i = 0; i < Recruited.Count; i++)
        {
            System.Console.WriteLine(Recruited[i]);
        }
}
Console.ReadLine();