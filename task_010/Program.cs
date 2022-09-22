using static System.Console;

Write("Введите трехзначное число: ");

int num = int.Parse(ReadLine()!);
int sec = num / 10 % 10;

WriteLine($"Вторая цифра числа = {sec}");