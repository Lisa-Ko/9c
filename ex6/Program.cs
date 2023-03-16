int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void PrintNumber(int number1, int number2, int score)
{
    int temporary = 0;
    if (score > 0)
    {
        Console.Write(number1 + number2 + " ");
        temporary = number1;
        number1 =number2;
        number2 += temporary;
        PrintNumber(number1, number2, score -= 1);
    }
}
//int number1 = GetNumber("Введите число M: ");
//int number2 = GetNumber("Введите число N: ");
//int score = GetNumber("Введите количество раз, сколько раз мы выведем число: ");
//PrintNumber(number1, number2, score );
PrintNumber(GetNumber("Введите число M: "), GetNumber("Введите число N: "), GetNumber("Введите количество раз, сколько раз мы выведем число: "));