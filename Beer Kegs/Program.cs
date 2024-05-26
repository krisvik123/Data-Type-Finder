int n = int.Parse(Console.ReadLine());
string biggestKegName = "";
decimal biggestKegVolume = 0m;

for (int i = 1; i <= n; i++)
{
    string model = Console.ReadLine();
    decimal radius = decimal.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    decimal volume = (decimal)Math.PI * (radius *   radius) * height;
    if (volume > biggestKegVolume)
    {
        biggestKegVolume = volume;
        biggestKegName = model;
    }
}
Console.WriteLine(biggestKegName);