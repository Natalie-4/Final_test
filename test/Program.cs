// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуетмя пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2",":-)"]

Console.Write("Введите кол-во элементов исходного массива: ");
int AmountOfElements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("_____Cоздание исходного массива_____");
Console.WriteLine();


string [] ArrayOriginal = new string [AmountOfElements]; // создала исходный пустой массив



Console.WriteLine("Введите элементы исходного массива: "); // узнали какие элементы будут внутри массива исходного


for (int i = 0; i < AmountOfElements; i++)
    {
        ArrayOriginal[i] = Convert.ToString(Console.ReadLine());
    }
Console.WriteLine();



void PrintArray (string[]array) // склеили исходный массив
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int CountElemetsLessFour(string[]array) // посчитали число элементов, длина которых не превышает 4 символа
{
int count1 = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count1 = count1 + 1;
        } 
        //Console.WriteLine(count1); 
    }  
    return count1;
}

int Count = CountElemetsLessFour(ArrayOriginal);
Console.WriteLine("Размерность нового массива: ");
Console.WriteLine(Count); 
Console.WriteLine();

Console.WriteLine("Исходный массив: ");
PrintArray(ArrayOriginal); // напечатали исходный массив
Console.WriteLine();

string [] ComposeNewArray(string[]array, int q)
{
  string [] newarray = new string [q];
  int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length < 4)
        {
           newarray[j] = array[i];
           j = j + 1;
        } 
    }
    return newarray;
}


Console.WriteLine("Новый массив: ");
PrintArray(ComposeNewArray(ArrayOriginal,Count));