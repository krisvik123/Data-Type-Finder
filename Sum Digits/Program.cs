int number = int.Parse(Console.ReadLine());

string numberStr = number.ToString();

int sum = 0;

foreach (char digit in numberStr)
{
    sum += int.Parse(digit.ToString());
}

Console.WriteLine(sum);