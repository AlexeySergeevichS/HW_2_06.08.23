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
int ThirdDigit(int tnum)
{
    while (tnum > 999)
    {
        tnum /= 10;
    }
    return tnum % 10;
}
bool CheckNum(int num)
{
    if (num < 100)
    {
        System.Console.WriteLine($"Третьей слева цифры нет");
        return false;
    }
    return true;
}
int num = InputNumber("Введи число: ");
if (CheckNum(num))
{
    System.Console.WriteLine($"Третья слева цифра {ThirdDigit(num)}");
}