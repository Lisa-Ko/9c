Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень");
int B = int.Parse(Console.ReadLine()!);
int Degree(int A,int B)
{ 
    if(B == 0) return 1;
    else return Degree(A, B-1) * A;
}
Console.WriteLine(Degree(A, B));