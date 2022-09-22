using static System.Console;

Write("Введите номер дня недели: ");
int day = int.Parse(ReadLine()!);

if(day > 0 & day < 8)
{
    string prefix = day == 6 | day == 7?"":"не ";
    WriteLine($"Это {prefix}выходной день");
}
else WriteLine("Введен неверный номер дня недели");