// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountNumbersMoreZero(int size)
{
    int sum = 0;
    int[] array = new int[size];
    Console.WriteLine($"Введите значения по порядку: ");

        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());

            if (array[i] > 0)
            {
                sum = sum + 1;
            }
        }
    return sum;
}

Console.WriteLine("Введите количество чисел, которое хотите проверить на условие к задаче: ");
int size = Convert.ToInt32(Console.ReadLine());

int sumResult = CountNumbersMoreZero(size);
Console.WriteLine($"Количество введённых чисел больше нуля равно {sumResult}.");
