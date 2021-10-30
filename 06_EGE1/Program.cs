// Дан целочисленный массив из 30 элементов. Элементы массива могут принимать целые значения от 0 до 100.
// Найти и вывести произведение элементов массива, которые имеют чётное значение и не оканчиваются на 0.


// Создание и выведение массива:
int[] CreateArray(int n)   // создание массива, указание его размера (n)
{
    int[] a = new int[n];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++) a[i] = random.Next(0, 101);
    return a;
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
}

int[] arr = CreateArray(30);
PrintArray(arr);

// Решение задачи:

long p = 1;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 0 && arr[i] % 10 != 0)
    {
        p = p * arr[i];
    }
Console.WriteLine();
Console.WriteLine(p);