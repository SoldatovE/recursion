Console.Clear();

// Задача №1
/*  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 Использовать рекурсию, не использовать циклы.*/


Console.Write("Введите натуральное  число  для подсчета в промежутке: M =  ");
int integerM = Convert.ToInt32(Console.ReadLine());

//int startValN = 1; // 1вариант решения

Console.Write("Введите натуральное  число  для подсчета в промежутке: N =  ");
int startValN = Convert.ToInt32(Console.ReadLine()); // 2вариант решения(не могу понять, как сделать, чтобы отрицательные цыфры не выводил,)

void ShowNumbers(int startValN, int end)
{
    if (startValN == end)
    {
        Console.Write(startValN);
        return;
    }

    Console.Write(startValN + " ");
    ShowNumbers(startValN + 1, end);

}
System.Console.Write("Натуральные числа в промежутке от M до N: ");
ShowNumbers(integerM, startValN); // 2вариант решения
//ShowNumbers(1, integerN); //1вариант решения