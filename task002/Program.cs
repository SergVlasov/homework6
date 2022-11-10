// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите 4 числа от 1 до 10 :");

float b1 = Convert.ToInt32(Console.ReadLine());
float k1 = Convert.ToInt32(Console.ReadLine());
float b2 = Convert.ToInt32(Console.ReadLine());
float k2 = Convert.ToInt32(Console.ReadLine());

float x = 0;
float y = 0;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
Console.WriteLine($"The point of intersection is ({x};{y})");