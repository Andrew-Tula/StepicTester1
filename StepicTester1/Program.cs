using System;
public class program
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        PrintSum(GetCubes(startValue, endValue));
    }

    public static int[] GetCubes(int a, int b)
    {
        int[] cubes = new int[0];
        for (int i = a; i <= b; i++)
        {
            Array.Resize(ref cubes, cubes.Length + 1);
            cubes[cubes.Length - 1] = i * i * i;
        }
        return cubes;
    }

    public static void PrintSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        Console.WriteLine(sum);
    }
}