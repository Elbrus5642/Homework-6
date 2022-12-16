/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Метод int GetQuantity (sting message) для получения количесва чисел для проверки (number > 0)
int GetQuantity(string message)
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
int quantity_numbers_from_keyboard = GetQuantity("Введите количество чисел, которе будет введено с клавиатуры: ");
Console.WriteLine($"Будет введено {quantity_numbers_from_keyboard} чисел");
Console.WriteLine();
// Метод для ввода числа с клавиатуры  int GetNumberForPosChecking(string message)
int GetNumberForPosChecking(string message)
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
// Программа для проверки (number > 0) и подсчёта количества положительных чисел
int index_pos_numbers = 0;
int number = 0;
for (int i = 0; i < quantity_numbers_from_keyboard; i++)
{
    number = GetNumberForPosChecking("Введите число:");
    if (number > 0) index_pos_numbers ++;
}
Console.WriteLine($"Из {quantity_numbers_from_keyboard} введённых чисел,  положительных {index_pos_numbers}");