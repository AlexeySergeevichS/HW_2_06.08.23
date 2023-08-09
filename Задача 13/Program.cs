/* Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
int InputNumber(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int CheckThirdDigit(int tnum)
{
    int count = 0;
    while (tnum / 10 > 0)
    {
        tnum = tnum / 10;
        count++;
    }
    return count - 1;
}
int ExpTen(int n)
{
    if (n == 0)
    {
        return 1;
    }
    int i = 1;
    int b = 10;
    while (i < n)
    {
        b = b * 10;
        i++;
    }
    return b;
}
int num = InputNumber("Введи число: ");
int nZero = CheckThirdDigit(num);
if (nZero >= 1)
{
    System.Console.WriteLine($"Третья слева цифра {num % ExpTen(nZero) / ExpTen(nZero - 1)}");
}
else
{
    System.Console.WriteLine($"Третьей слева цифры нет");
}