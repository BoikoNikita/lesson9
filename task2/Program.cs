﻿Console.WriteLine("Введите Max: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Min: ");
int m = Convert.ToInt32(Console.ReadLine());

void Rec (int n)
{
    if(n<m)
    return;
    Console.Write(n + " ");
    Rec(n-1);
}

int SumRec (int n)
{
    if(n<m) return 0;
    else return n + SumRec (n-1);
}
Rec(n);
Console.WriteLine();
SumRec(n);
Console.WriteLine ("Сумма чисел равна: " + (SumRec(n)));