//Итоговая задача:
//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array1 = new string[8] {"123", "23", "hello", "world", ":)", "Russia", "96", "abc"};
string[] array2 = new string[array1.Length];

void FillArray(string[] array1, string[] array2)
{
    int count = default;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

FillArray(array1, array2);
Console.WriteLine();
Console.Write("первоначальный массив: ");
PrintArray(array1);
Console.WriteLine();
Console.Write("массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(array2);
Console.WriteLine();