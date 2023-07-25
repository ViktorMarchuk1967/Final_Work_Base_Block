/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int InputNum(string message) //ввод параметров
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string[] CreateArray(int size) //создание массива (ссылки на массив) с заданным размером 
{
    return new string[size];
}

void FillArray(string[] array) //заполнение массива
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i} элемент: \t");
        array[i] = Console.ReadLine()!;
    }
}


void SelectArray(string[] array) //изменение массива
{
    int count = 0;
    foreach (string item in array)
        if (item.Length <= 3) count++;
    string[] resArray = CreateArray(count);
    int i = 0;
    foreach (string item in array)
        if (item.Length <= 3)
        {
            resArray[i] = item;
            i++;
        }
    string txt = PrintArray(resArray);
    Console.WriteLine(txt);
}


string PrintArray(string[] array) //вывод массива в строку
{
    string res = String.Empty;
    res = "[";
    for (int i = 0; i < array.Length; i++)
    {
        res += '"';
        res += array[i];
        if (i < array.Length - 1) res += '"' + ", ";
        else res += '"';
    }
    res += "]";
    return res;
}

int size = InputNum("Введите размер массива: ");
string[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
SelectArray(myArray);
