/*
ЗАДАЧА: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

//Выводим массив в консоль
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//Находим элементы с <=3 символами
void ArrayValuesThreeCharacters(string[] array, string[] newArray)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

// Создание массивов
string[] array = new string[5] { "array", "new", "45w", "line", "012" };
string[] newArray = new string[array.Length];

// Вывод
ArrayValuesThreeCharacters(array, newArray);
PrintArray(newArray); 