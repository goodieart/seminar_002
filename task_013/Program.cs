using static System.Console;

Write("Введите число: ");
int num = int.Parse(ReadLine()!);
int temp = num,
    length = 0, pow10 = 1;

// Определяем длину числа
while(temp > 0)
{
    length++;
    temp /= 10;
}

// Проверяем, есть ли третья цифра
if(length < 3)
{
    WriteLine("Третьей цифры нет");
    return;
}

for(int i = 0; i < length - 3; i++) pow10 *= 10; /* Здесь можно использовать Math.Pow, 
                                                    но в этом случае требуется множество конвертаций (приведение типов); */
int third = num / pow10 % 10;
Write($"Третья цифра числа = {third}");