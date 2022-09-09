// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трезначное число");
int x = Convert.ToInt32(Console.ReadLine());
{
    int result = (x / 10) % 10;
    Console.Write($"Вторая цифра числа : {Math.Abs(result)}");
}