// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным 
//элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] nums = new double[size];
FillArrayRandomNumbers(nums);
PrintArray(nums);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < nums.Length; x++)
{
    if (nums[x] > max) max = nums[x];
    if (nums[x] < min) min = nums[x];
}

Console.WriteLine($"-> " + Math.Round(max - min, 2));

void FillArrayRandomNumbers(double[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;// вещественные числа с плавающей запятой
    }
}
void PrintArray(double[] nums)
{
    Console.Write("[ ");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.Write("]");
}