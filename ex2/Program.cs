Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
int Sum(int m,int n)
{ 
    if(n == m) return n;
    else return Sum(m - 1, n) + m;
}
Console.WriteLine(Sum(m,n));