﻿Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
int Akk(int n,int m)
{ 
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akk(n - 1, 1);
    if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
    return Akk(n,m);
}
Console.WriteLine(Akk(n,m));