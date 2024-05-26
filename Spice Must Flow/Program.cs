using System;

int source = int.Parse(Console.ReadLine());
int days = 0;
int spice = 0;


while (source >= 100)
{
    days++;
    spice += source;
    spice -= 26;
    source -= 10;
}

if (source >= 26 )
{
    spice -= 26;
}
if (source == 99)
{
    spice = 0;
}

Console.WriteLine(days);
Console.WriteLine(spice);
