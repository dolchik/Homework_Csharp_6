// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

void CountPositiveDigits(int[] array, out int count)
{    
    count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0) count++;
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
int[] array = new int[sizeArray];

Console.WriteLine($"Введите {sizeArray} случайных чисел через пробел:");
string[] arrayDigits =  Console.ReadLine().Split(' ');
for (int i =0; i < arrayDigits.Length; i++)
{
    array[i] = int.Parse(arrayDigits[i]);
}
Console.WriteLine(string.Join(", ", array));
CountPositiveDigits(array, out int count);
System.Console.WriteLine($"Среди введных ицфр, положительных: {count}");