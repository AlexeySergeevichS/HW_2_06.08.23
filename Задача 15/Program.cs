/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
int InputNumber(string message)
{
 System.Console.Write(message);
 return int.Parse(Console.ReadLine()!);
}
string CheckDayOfWeek(int num)
{
    return num==6||num==7 ? "Да":"Нет";
}
bool ValidDay(int n)
{
    if (n>0 && n<=7)
    {
        return true;
    }
    System.Console.WriteLine("Это не день недели");
    return false;
}
int n= InputNumber("Введи день недели: ");
if (ValidDay(n))
{
System.Console.WriteLine(CheckDayOfWeek(n));
}