// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int dayNumber = int.Parse(Console.ReadLine());
string result = "Это выходной :)";
if (dayNumber<6) result = "Это рабочий день :(";
Console.WriteLine(result);
