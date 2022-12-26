// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void RandomNumbers (int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = new Random().Next(0,100);
    }
}
void PrintArray (int [] numbers)
{
    Console.Write ("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write (numbers[i] + " ");
    }
    Console.Write ("]");
    Console.WriteLine ();
}

int size = Convert.ToInt32(3);
int[] numbers = new int[size];
RandomNumbers (numbers);
Console.WriteLine ("Массив: ");
PrintArray (numbers);
int sum = 0;

for (int A = 0; A < numbers.Length; A++)
    if (numbers[A] % 2 == 1)
    sum = sum + numbers[A];
        if (sum == 0)
        Console.WriteLine ("Нечетных чисел нет!");
        else
        Console.WriteLine ($"Всего {numbers.Length} числа, сумма нечетных чисел равна:{sum}.");