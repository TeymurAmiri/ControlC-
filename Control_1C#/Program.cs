﻿// Нужно написать программу, которая из имеющегося массива строк, формирует массив из строк, длинна которых меньше
//  или равна 3 символа Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] firstArray;
Console.Write($"Введите элементы массива строк через запятую или пробел: ");
string array = Console.ReadLine();
firstArray = array.Split(' ');

Console.Write($"Начальный массив -> ");
Console.WriteLine(string.Join(' ', firstArray));