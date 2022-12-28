// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EntryDigit(string str) // пользователь вводит число цифр в массиве и мы его считываем
{
Console.Write(str);
int number = int.Parse(Console.ReadLine());
return number;
}

Console.Clear();
Console.WriteLine("Точка пересечения x и y заданна уравнениями y = k1 * x + b1, y = k2 * x + b2");
double b1 = EntryDigit("Введите b1 ");
double k1 = EntryDigit("Введите k1 ");
double b2 = EntryDigit("Введите b2 ");
double k2 = EntryDigit("Введите k2 ");

// k1 * x + b1 = k2 * x + b2 -> (k1 -k2) * x = b2 - b1 -> x = (b2 - b1) / (k1 -k2)
// y = k1 * x + b1 -> y = k1 * (b2 - b1) / (k1 -k2) +b1

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1; 

Console.WriteLine($"Точка пересечения x и y: [{x}, {y}]");