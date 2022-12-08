void QuickSort(int?[] arr, int begin, int end)  //функция быстрой сортировки почитай как она работает в файле с задачей
{
    if (end < 0)
        end = arr.Length - 1;
    if (begin >= end)
        return;
    int middleIndex = (end - begin) / 2 + begin, currentIndex = begin;
    Swap(arr, begin, middleIndex);
    for (int i = begin + 1; i <= end; ++i)
    {
        if (arr[i] >= arr[begin] || arr[i] == null)
        {
            currentIndex++;
            Swap(arr, currentIndex, i);
        }
    }
    Swap(arr, begin, currentIndex);
    QuickSort(arr, begin, currentIndex - 1);
    QuickSort(arr, currentIndex + 1, end);
}
void Swap(int?[] arr, int i, int j) //функция чтоб менять местами числа
{
    (arr[j], arr[i]) = (arr[i], arr[j]);
}
void PrintNullable(int? number) //функция, которая выводит слово null если элемент пустой
{
    if (number.HasValue)
    {
        
        Console.Write(number); // аналогично предыдущей строке
    }
    else
    {
        Console.Write("null");
    }
}

Random random = new Random();

int?[] mas = new int?[100];

Console.Write("Введите число от 1 до 100: "); int N = Convert.ToInt32(Console.ReadLine());  //вводим число

for (int i = 0; i < N; i++) //заполняем массив null элементами
{
    mas[i] = null;
}
for (int i = 0; i < N; i++) //заполняем массив рандомными числами на рандомных местах столько раз, сколько мы ввели в N
{
    mas[new Random().Next(mas.Length)] = random.Next(mas.Length);
}

Console.Write("[ ");
for (int i = 0; i < mas.Length; i++)    //выводим массив
{
    PrintNullable(mas[i]);
    Console.Write(" ");
}
Console.Write("]");

Console.ReadKey();

QuickSort(mas, 0, mas.Length - 1);  //вызываем функцию быстрой сортировки
Array.Reverse(mas);

Console.Write("[ ");
for (int i = 0; i < mas.Length; i++)    //выводим массив
{
    PrintNullable(mas[i]);
    Console.Write(" ");
}
Console.Write("]");