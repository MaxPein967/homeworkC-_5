// Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
FillArrayRandomNumbers(nums);
PrintArray(nums);
int sum = 0;

for (int x = 1; x < nums.Length; x += 2)
    sum = sum + nums[x];

Console.WriteLine($" ->  {sum}");

void FillArrayRandomNumbers(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(1, 100);
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