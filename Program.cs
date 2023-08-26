using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pizdec");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
                case 1: //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int result=1;
                    for (int i = 0; i < num2; i++)
                    {
                        result *= num1;
                        
                    }
                   Console.WriteLine(result);
                }
                break;
                case 2: //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
                {
                    string? num1 = Console.ReadLine();
                    int result=0;
                    for (int i=0; i<num1.Length; i++)
                        
					{

                        result += (int)Char.GetNumericValue(num1[i]);
					}
                    Console.WriteLine(result);
                }
                break ;
                case 3: //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 

                {
                    int[] nums = new int[8] ;
                    Random random = new Random();

                    for (int i=0; i<nums.Length; i++)
				    {
                        nums[i] = random.Next(50);
                       
				    }
                    Console.Write("[");
                    for (int i = 0; i < nums.Length; i++)
                    { 
                        Console.Write($"{ nums[i]}, ");
                    }
                    Console.WriteLine("]");

                }
                /* 
                 * int[] nums = new int[8] ;
                    Random random = new Random();
                    Console.Write("[");
                    for (int i=0; i<nums.Length; i++)
				    {
                        nums[i] = random.Next(50);
                       Console.Write($"{ nums[i]}, ");
				    }
                    Console.WriteLine("]");
                 */
                break;
        }

    }
}