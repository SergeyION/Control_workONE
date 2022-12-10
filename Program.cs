string[] arr = { "Neth", "Arg", "France", "Eng", "Croa", "Spain", "Braz", "Swit" };
// string[] result = [arr.Length];

// Напишу метод который будет выводить первичный массив в консоль

void PrintArray(string[] result) // Первичный массив строк
{
    int count = result.Length; // Переменная равна длинне первичного массива
    for (int i = 0; i < count; i++) // Цикл прохода по всем элементам первичного массива
    {
        Console.Write($"{result[i]} "); // Вывод в консоль
    }
    Console.WriteLine();
}

// Напишем метод который будет возвращать отсортированный массив

string[] SortArray(string[] array)
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) result[i] = array[i];
        
    }
    return result;
}   

PrintArray(SortArray(arr)); // Проверка работы метода