Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
string NumberString(int n,int m)
{ 
    if(n <= m) return NumberString(n+1, m) + $"{n} ";
    else return String.Empty;
}
Console.WriteLine(NumberString(n, m));