/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int GetKoeff(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

float k1 = GetKoeff($"Введите коэффициент, k1: ");
float b1 = GetKoeff($"Введите свободный член уравнения первой прямой,  b1: ");
float k2 = GetKoeff($"Введите коэффициент, k2: ");
float b2 = GetKoeff($"Введите свободный член уравнения второй прямой,  b2: ");

Console.WriteLine($"Первая прямая y = {k1}*x + {b1}");
Console.WriteLine($"Вторая прямая y = {k2}*x + {b2}");
// Определение точки совпадения
float x_root = 0;
float y_root = 0;
x_root = (b2 - b1) / (k1 - k2);
y_root = k1 *((b2 - b1) / (k1 - k2))  + b1;
Console.WriteLine($"Координаты точки пересечения прямых: x= {x_root} y = {y_root} ");