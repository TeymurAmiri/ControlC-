// Нужно написать программу, которая из имеющегося массива строк, формирует массив из строк, длинна которых меньше
//  или равна 3 символа Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] firstArray;
Console.Write($"Введите элементы массива строк через запятую или пробел: ");
string array = Console.ReadLine();
firstArray = array.Split(' ');

Console.Write($"Начальный массив -> ");
Console.WriteLine(string.Join(' ', firstArray));

string[] secondArray = new string[firstArray.Length];
CreatSecondArray(firstArray, secondArray);

Console.Write($"Итоговый массив -> ");
Console.Write(string.Join(' ', secondArray));



void CreatSecondArray(string[] array1, string[] array2)
{
    int digit = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[digit] = array1[i];
            digit++;
        }
    }
}
