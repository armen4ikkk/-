using System;
using static System.Console;

Clear();
WriteLine("Введите число: ");
double N = double.Parse(ReadLine());

Write($"{N} -> ");
for(double i = 1; i <= N; i++) {
    Write($"{Math.Pow(i, 3)}{(i != N ? "," : "\n")}");
}