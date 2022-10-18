// Программа запрашивает у пользователя три числа и выводит на экран максимальное число.

double[] Array;
Array = new double[3];
int i = 0;
Console.Write($"Введите {i + 1} число: ");
Array[i] = Double.Parse(Console.ReadLine());
i++;
Console.Write($"Введите {i + 1} число: ");
Array[i] = Double.Parse(Console.ReadLine());
i++;
Console.Write($"Введите {i + 1} число: ");
Array[i] = Double.Parse(Console.ReadLine());
double max_array = Array.Max();
Console.WriteLine("Максимальное число: " + max_array);
Console.ReadKey();
