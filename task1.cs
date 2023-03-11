using System;

int sum = 0;
int index = 0;
double avg;
Console.WriteLine("Enter number of array size");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[size];
for (int i = 0; i < size; i++)
    nums[i] = Convert.ToInt32(Console.ReadLine());
for (int j = 0; j < size; j++)
    sum += nums[j];
avg = sum / size;
int maxValue = nums[0];
int minValue = nums[0];
while (index < size)
{
    if (maxValue < nums[index])
        maxValue = nums[index];
    index++;
}
index = 0;
while (index < size)
{
    if (minValue > nums[index])
        minValue = nums[index];
    index++;
}
Console.Write("Array's numbers: ");
for (int i = 0; i < size; i++)
    Console.Write(" " + nums[i] + " ");

Console.WriteLine("\nSum of the array's number is " + sum);
Console.WriteLine("Avarage value of the array's number is " + String.Format("{0:0.00}", avg));
Console.WriteLine("Max value of array is " + maxValue);
Console.WriteLine("Min value of array is " + minValue);

