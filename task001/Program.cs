// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Readint(string message)
{
    Console.Write(message);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}

int[] newArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Readint($" Введите {i + 1}-й элемент: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

//------------------------------------------------

int length = Readint("Введите количество элементов -> ");
int[] array;
array = newArray(length);
PrintArray(array);
Console.WriteLine($"Количество элементов больше 0 - {CountPositive(array)}");