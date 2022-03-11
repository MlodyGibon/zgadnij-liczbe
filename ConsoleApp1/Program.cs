Random r = new Random();

int los = r.Next(1, 10);
int zgadnij = 0;
bool petla = false;

Console.WriteLine("Wybieram liczbe od 1 do 10");

while (!petla)
{
    Console.Write("zgadnij: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out zgadnij))
    {
        Console.WriteLine("wpisz cyfre");
        continue;
    }

    if (zgadnij < los)
    {
        Console.WriteLine("wyzej");
    }
    else if (zgadnij > los)
    {
        Console.WriteLine("Nizej");
    }
    else
    {
        petla = true;
        Console.WriteLine("Brawo zgadłeś!");
    }
}