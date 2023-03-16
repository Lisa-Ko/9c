Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int NumberSum(int n)
{ 
   if (n == 0) return 0;
   return NumberSum(n/10) + n%10;
}
Console.WriteLine(NumberSum(n));