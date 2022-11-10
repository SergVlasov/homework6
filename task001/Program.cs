// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter some numbers: ");
int[] numbers = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(i=>int.Parse(i)).ToArray<int>();;

void PrintArray(int[] numbers)
{
    int i = 0;
    int count = numbers.Length;
    while (i < count)
    {
        Console.Write($"[{numbers[i]}]");
        i++;
    }
}
int[] array = new int[numbers.Length];
PrintArray(numbers);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) count++;
}
Console.WriteLine();
Console.WriteLine($"Number of digits greater than zero = {count}");
