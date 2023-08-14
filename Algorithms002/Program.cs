// Big O Notation

// int[] array = new int[5];
// for (int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine(array[3]);

// Сложгость алгоритма О(1)

// [4, 5, 3, 1, 2]
// O(n)
// [1, 2, 3, 4, 5] = O(n*log n)
// ((5 + 1) / 2) * 5 = O(1)
// n < n * log(n) + 1

// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// int summa = 0;
// for (int i = 0; i < n; i++)
//     summa += array[i];
// Console.WriteLine(summa);

// O(n^2)

// Таблица умножения


Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица умножения для числа {0}:", n);
for (int i = 1; i <= 10; i++)
{
    int result = n * i;
    Console.WriteLine("{0} * {1} = {2}", n, i, result);
}