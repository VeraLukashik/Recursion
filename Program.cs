// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.Write("Введите первое число: ");
// int firstNumber= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// void ShowNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     if (start < end)
//     {
//        ShowNumbers(start + 1, end); 
//     }
//     if (start > end)
//     {
//         ShowNumbers(start - 1, end);
//     }
// }
// ShowNumbers(firstNumber,secondNumber);

// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int[] array = {1, 2, 5, 0, 10, 34};
int size = array.Length;
void ShowArray (int[] arr,int size)
{
    if (size == 0)
    {
        Console.Write(array[size]);
        return;
    }
    Console.Write(array[size-1] + " ");
    size--;
    ShowArray(array, size);
}
ShowArray(array, size);
