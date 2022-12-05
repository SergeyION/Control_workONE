string[] semiFinal = { "Netherlands", "Argentina", "France", "England", "Croatia", "Spain", "Brazil", "Switzerland" };
// int[] arr = new int[] { 1, 3, 5, 7, 9 };

// Напишем метод который будет выводить массив на консоль
void PrintArray(string[] array) // Массив строк
{
    int count = semiFinal.Length; // Переменная равна длинне массива
    for (int i = 0; i < count; i++) // Цикл прохода по всем элементам массива
    {
        Console.WriteLine($"{array[i]} "); // Вывод без перехода на следующую строку
    }
    Console.WriteLine();
}
PrintArray(semiFinal); // проверка работы метода