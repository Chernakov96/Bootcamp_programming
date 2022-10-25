Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив:[" + string.Join(", ", array) + "]" );
for (int i = 0; i < n-1; i++)
{
    int minIndex = i;
    for (int j = i+1; j < n; j++)
    {
        if(array[j] < array[minIndex]) minIndex = j;
    }
    int temp;
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив:[" + string.Join(", ", array) + "]" );

/*
char[] array = new char[5];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

*/