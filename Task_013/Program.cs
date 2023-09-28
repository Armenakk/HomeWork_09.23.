// // // Напишите программу, которая выводит третью цифру 
// // // заданного числа или сообщает, что третьей цифры нет.
// // // 645 -> 5
// // // 78 -> третьей цифры нет
// // // 32679 -> 6


Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
int num = number;
string result = "В числе " + number + " третьей цифры нет.";

if (number > 100)
{
    while (num > 1000)
    {
        num /= 10;
    }
    num = num % 10;
    result = "Третья цифра в числе " + number + " -> " + num;
}
Console.WriteLine(result);