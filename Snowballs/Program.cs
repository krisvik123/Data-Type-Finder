﻿using System.Numerics;

int n = int.Parse(Console.ReadLine());

BigInteger bestValue = 0;
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;

for (int i = 0; i < n; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());

    BigInteger value = BigInteger.Pow(snow / time, quality);

    if (value >= bestValue)
    {
        bestValue = value;
        bestSnow = snow;
        bestTime = time;
        bestQuality = quality;
    }
}

Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");