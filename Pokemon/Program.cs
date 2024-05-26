long initialPower = long.Parse(Console.ReadLine());
long distance = long.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());

long currentPower = initialPower;
int pokeCount = 0;

while (currentPower >= distance)
{
    currentPower -= distance;
    pokeCount++;

    if (currentPower == initialPower / 2 && exhaustionFactor != 0)
    {
        currentPower /= exhaustionFactor;
    }
}

Console.WriteLine(currentPower);
Console.WriteLine(pokeCount);

