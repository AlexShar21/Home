// Дни недели
Console.WriteLine("Введите цифру дня недели:  ");
int x = Convert.ToInt32(Console.ReadLine());

switch(x)
{
    case 1:
        System.Console.WriteLine ("Это понедельник - не выходной.");
        break;
    case 2:
        System.Console.WriteLine("Это вторник - не выходной.");
        break;
    case 3:
        System.Console.WriteLine("Это среда - не выходной.");
        break;
    case 4:
        System.Console.WriteLine("Это четверг - не выходной.");
        break;
    case 5:
        System.Console.WriteLine("Это пятница - не выходной.");
        break;
    case 6:
        System.Console.WriteLine("Это суббота - выходной.");
        break;
    case 7:
        System.Console.WriteLine("Это воскресенье - выходной.");
        break;
        }
