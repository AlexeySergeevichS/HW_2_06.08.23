/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
int InputNumber(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int SecondDigit(int num)
{
    return num/10 % 10;
}

int number = InputNumber("Введи трехзначное число :");
System.Console.WriteLine($"Вторая цифра {SecondDigit(number)}");
