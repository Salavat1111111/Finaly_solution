Console.Clear();


/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести  с квлавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int number)
{
    string[] result = new string[number];

    for (int i = 0; i < result.Length; i++)
    {

        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        result[i] = Console.ReadLine();

    }
    return result;
}

void ShowArray(string[] TextArray)
{
    for (int i = 0; i < TextArray.Length; i++)
    {
        Console.Write($"{TextArray[i]} ");
    }
    Console.WriteLine();
}

string[] mesage = CreateArray(num);
ShowArray(mesage);
