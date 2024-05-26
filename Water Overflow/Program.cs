int n = int.Parse(Console.ReadLine());

int sumTank = 0;
int finalNumber = 0;

for (int i = 0; i < n; i++)
{
    int quantities = int.Parse(Console.ReadLine());
    sumTank += quantities;

    if (sumTank <= 255)
    {
        finalNumber = sumTank;
    }
    else if (sumTank >= 255)
    {
        sumTank -= quantities;
        Console.WriteLine("Insufficient capacity!");
    }
}
Console.WriteLine(finalNumber);