//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число:  ");
int x = Convert.ToInt32(Console.ReadLine());

int y = 10;
int count = 1;

if (x < 100 && x > -100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    while (x / y > 99 || x / y < -99)
    {
        y = y * 10;
        count = count * 10;
    }
    long result = (x % y) / count;
    Console.Write($"Третья цифра числа : {Math.Abs(result)}");
}