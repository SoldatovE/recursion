Console.Clear();

// Задача №1
/*  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 Использовать рекурсию, не использовать циклы.*/


Console.Write("Введите натуральное  число, для подсчета в промежутке от М до N:  ");
int integerN = Convert.ToInt32(Console.ReadLine());

//int startValM = 1; // 1вариант решения

Console.Write("Введите натуральное  число N, для подсчета в промежутке от М до N:  ");
int startValМ = Convert.ToInt32(Console.ReadLine()); // 2вариант решения(не могу понять, как сделать, чтобы отрицательные цыфры не выводил,)

void ShowNumbers(int startValМ, int end)
{
    if (startValМ == end)
    {
        Console.Write(startValМ);
        return;
    }

    Console.Write(startValМ + " ");
    ShowNumbers(startValМ + 1, end);

}
ShowNumbers(integerN, startValМ); // 2вариант решения
//ShowNumbers(1, integerN); //1вариант решения