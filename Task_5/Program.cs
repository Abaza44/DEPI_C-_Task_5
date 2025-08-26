using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace Task_5
{
    internal class Program
    {

        
        static void Main()
        {

            #region Part_1
            #region 1
            //try
            //{
            //    Console.WriteLine("Enter first Number :");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second Number :");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);

            //}
            //catch (DivideByZeroException EX) {
            //    Console.WriteLine(EX.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            //The finally block contains code that will always run after the try/catch section no matter what happens
            #endregion



            #region 2
            //    bool flag2;
            //    bool flag1;



            //do
            //{
            //    Console.WriteLine("Enter Your first Positive Number :");
            //    string input1 = Console.ReadLine();
            //    int num1 = 0;
            //    int num2 = 0;
            //    flag1 = int.TryParse(input1, out num1)&&num1>0;
            //    Console.WriteLine("Enter Your Second Positive Number :");
            //    string input2 = Console.ReadLine();
            //    flag2 = int.TryParse(input2, out num2)&&num2>0&&num2>(num1+1);
            //}while (!(flag1&&flag2));

            //Console.WriteLine("Correct Input");
            //TryParse() makes the program more robust because it avoids exceptions for invalid input and gives you a safe way to check and handle the result before using it.
            #endregion



            #region 3

            //int? number = null; 


            //int value = number ?? 10;
            //Console.WriteLine( value);

            //Console.WriteLine($"HasValue: {number.HasValue}");

            //try
            //{
            //    Console.WriteLine( number.Value);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion




            #region 4


            //try
            //{
            //    int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //    Console.WriteLine("Enter Index 0-4");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine(arr[num]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finish");
            //}

            //Accessing outside valid indexes might lead to reading garbage values or corrupting memory.
            //Out-of-bound access can cause your program to crash unexpectedly disrupting the user’s experience




            #endregion



            #region 5

            //int[,] arr = new int[3, 3];

            //for (int i = 0; i < arr.GetLength(0); i++) 
            //{

            //    for (int j = 0;j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter Value of {i+1} , {j+1} Element ");
            //        arr[i,j] = int.Parse(Console.ReadLine());
            //    }



            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    int sum_row = 0;
            //    int sum_col = 0;
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        sum_row += arr[i, j];
            //        sum_col += arr[j, i];
            //    }

            //    Console.WriteLine($"Sum of {i + 1} Row = {sum_row}");
            //    Console.WriteLine($"Sum of {i + 1} Col = {sum_col}");


            //}


            // GetLength(dimension) method is used to find how many elements exist along a specific dimension of a multi-dimensional array
            #endregion



            #region 6
            //int col;
            //int row = 3;
            //int[][] arr=new int[row][];
            //for (int i = 0; i < row; i++)
            //{
            //    Console.WriteLine($"Enter size of Columns of {i+1} Row");
            //    col = int.Parse(Console.ReadLine());
            //    arr[i] = new int[col];
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{

            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine($"Enter Value of {i + 1} , {j + 1} Element ");
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0;i < arr.Length; i++)
            //{
            //    for(int j = 0;  j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] +"  " );  
            //    }
            //    Console.WriteLine("\n");
            //}

            //Rectangular Arrays([,])
            //Memory layout:    

            //All elements are stored in one contiguous block of memory.

            //Think of it as one big grid.


            //Jagged Arrays([][])
            //Memory layout:
            //Stored as an array of arrays.
            //The outer array holds references to inner arrays, which are stored separately in memory.
            //Rows can be of different lengths.

            #endregion





            #region 7
            //Console.Write("Enter Your name");
            //string? name = Console.ReadLine(); 

            //if (string.IsNullOrEmpty(name))
            //{
            //    name = null;
            //}
            //Console.WriteLine(name!);

            #endregion


            #region 8
            //int number = 5;

            //// Boxing
            //object boxed = number;
            //Console.WriteLine($"Boxed value: {boxed}");

            //// Unboxing 
            //int unboxed = (int)boxed;
            //Console.WriteLine($"Unboxed value: {unboxed}");

            //try
            //{
            //    double wrongUnbox = (double)boxed; 
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //}


            //Boxing and unboxing cause performance overhead because they involve allocating memory on the heap and potentially causing garbage collection
            #endregion

            #region 9
            //static void SumMul(int a, int b, out int sum, out int product)
            //{
            //    sum = a + b;         
            //    product = a * b;     
            //}


            //    int x = 5, y = 3;
            //    int resultSum, resultProduct; 

            //    SumMul(x, y, out resultSum, out resultProduct);

            //    Console.WriteLine($"Sum = {resultSum}");
            //    Console.WriteLine($"Product = {resultProduct}");
            //ecause out parameters are meant to return data from the method, the compiler requires that they be assigned a value before the method exits to ensure they always have a defined value when used
            #endregion


            #region 10
            //static void PrintMessage(string message, int times = 3) 
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        Console.WriteLine(message);
            //    }
            //}



            //    PrintMessage("Hello");

            //    Console.WriteLine("---");


            //    PrintMessage("Hi", 4);

            //    Console.WriteLine("---");


            //    PrintMessage(times: 3, message: "Named Params Example");

            //Because parameters are matched by position unless specified by name. If optional parameters were in the middle, the compiler wouldn’t know whether to skip them or match the next argument, causing ambiguity.


            #endregion


            #region 11
            //int[]? numbers = null;

            //int? length = numbers?.Length;

            //Console.WriteLine($"Length: {length ?? -1}");


            //numbers = new int[] { 1, 2, 3 };
            //length = numbers?.Length;
            //Console.WriteLine($"Length after assigning: {length}");

            //It checks whether the object is null before accessing its members>> and returns null
            #endregion


            #region 12
            //Console.Write("Enter a day of the week: ");
            //string? day = Console.ReadLine();

            //int dayNumber = day?.ToLower()
            //    switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => -1 // default
            //};


            //Console.WriteLine($"Day number: {dayNumber}");
            //switch expression is preferred when you want a more concise >> readable >> expression-based way to map a value to another

            #endregion

            #region 13

            //static int SumArray(params int[] numbers)
            //{
            //    int sum = 0;
            //    foreach (int num in numbers)
            //    {
            //        sum += num;
            //    }
            //    return sum;
            //}

            
                
            //    int result1 = SumArray(1, 2, 3, 4, 5);
            //    Console.WriteLine($"Sum of individual values: {result1}");

            //    int[] arr = { 10, 20, 30 };
            //    int result2 = SumArray(arr);
            //    Console.WriteLine($"Sum of array: {result2}");
            //You can have only one params parameter in a method.
            #endregion
            #endregion






            #region Part_2

            #region 1

            //Console.WriteLine("Enter positive Number");
            //int num =int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            #endregion



            #region 2

            //Console.WriteLine("Enter number : ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(i * num + " ");
            //}
            //Console.WriteLine();
            #endregion




            #region 3
            //Console.WriteLine("Enter Positive Number : ");
            //int num=int.Parse(Console.ReadLine());

            //for (int i = 2; i <=num; i+=2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();


            #endregion



            #region 4

            //Console.WriteLine("Enter First Number : ");

            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number : ");
            //int num2=int.Parse(Console.ReadLine());
            //int cnt = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    cnt *= num1;
            //}
            //Console.WriteLine(cnt);
            #endregion


            #region 5

            //Console.WriteLine("Enter String");

            //string str = Console.ReadLine();

            //str = new string(str.Reverse().ToArray());

            //Console.WriteLine(str);

            #endregion



            #region 6

            //Console.WriteLine("Enter String");

            //string str = Console.ReadLine();

            //str = new string(str.Reverse().ToArray());

            //Console.WriteLine(str);

            #endregion



            #region 7

            //Console.Write("Enter size of array: ");
            //int N = int.Parse(Console.ReadLine());

            //int[] arr = new int[N];
            //Console.WriteLine("Enter array elements:");

            //for (int i = 0; i < N; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = -1;
            //int element = 0;
            //int startIndex = -1, endIndex = -1;


            //for (int i = 0; i < N; i++)
            //{
            //    int first = Array.IndexOf(arr, arr[i]);         
            //    int last = Array.LastIndexOf(arr, arr[i]);       

            //    int distance = last - first - 1;                 

            //    if (distance > maxDistance)
            //    {
            //        maxDistance = distance;
            //        element = arr[i];
            //        startIndex = first;
            //        endIndex = last;
            //    }
            //}

            //if (maxDistance >= 0)
            //{
            //    Console.WriteLine($"Element: {element}");
            //    Console.WriteLine($"Longest distance: {maxDistance} cells");
            //    Console.WriteLine($"Between index {startIndex} and {endIndex}");
            //}
            //else
            //{
            //    Console.WriteLine("No matching elements found.");
            //}
            #endregion



            #region 8

            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();

            //Console.WriteLine(string.Join(" ", sentence.Split(' ').Reverse()));


            #endregion




            #endregion
        }
    }
}
