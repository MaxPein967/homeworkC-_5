// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите 
//программу, которая покажет количество чётных чисел 
//в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
FillArrayRandomNumbers(nums);
PrintArray(nums);
int count = 0;

for (int x = 0; x < nums.Length; x++)
    if (nums[x] % 2 == 0)
        count++;

Console.Write($" -> {count} ");

void FillArrayRandomNumbers(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] nums)
{
    Console.Write("[ ");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + ", ");
    }
    Console.Write("]");
}