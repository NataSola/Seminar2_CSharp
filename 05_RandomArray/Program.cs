// Заполнение массива случайными числами

int[] a = new int[10];
Random rnd;
rnd = new Random();
for (int i = 0; i < 10; i++)
{
    a[i] = rnd.Next(0, 100);
}
for (int i = 0; i < 10; i++)
{
    Console.Write(a[i] + " ");
}
