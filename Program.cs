// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите размер вашего массива: ");
int size = int.Parse(Console.ReadLine());

string[] array = Enter(size);
Console.WriteLine($"Ваш заданный массив: [{String.Join(" ", array)}]");

string[] arrayShort = CheckElement(size);
Console.WriteLine($"Все элементы массива меньше 3х символов: [{String.Join(" ", arrayShort)}]");


string[] Enter(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}й элемент массива из {size} элементов: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] CheckElement(int size)
{
    string[] array3elements = new string[size];
    for (int i = 0; i < array3elements.Length; i++)
    {
        if (array[i].Length <= 3)
            array3elements[i] = array[i];
    }
    return array3elements;
}
