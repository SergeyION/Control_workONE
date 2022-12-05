string[] semiFinal = { "Netherlands", "Argentina", "France", "England", "Croatia", "Spain", "Brazil", "Switzerland" };
string[] FinaleFootball = semiFinal.Length;


// Метод который перебирает первичный массив и взвращает result


// Напишу метод который будет выводить первичный массив в консоль
void PrintArray(string[] array) // Первичный массив строк
{
    int count = semiFinal.Length; // Переменная равна длинне первичного массива
    for (int i = 0; i < count; i++) // Цикл прохода по всем элементам первичного массива
    {
        Console.WriteLine($"{array[i]} "); // Вывод в консоль
    }
    Console.WriteLine();
}
PrintArray(semiFinal); // Проверка работы метода