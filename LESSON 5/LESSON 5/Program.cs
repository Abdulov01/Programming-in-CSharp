using System;
using System.Collections;

class Program
{
    static void Main1()

    {

        //Task 1 - Write a program in C# to display the first 10 natural numbers

        Console.WriteLine("Program in C# to display the first 10 natural numbers");

        int[] NaturalNumbers = new int[10];
        

        for (int i = 1; i <=10; i++)
        {
          
            NaturalNumbers[i-1] = i;
            Console.WriteLine(i);


        }


    }

    static void Main2(string[] args)
    {
        //Task 2 - Write a C# program to find the sum of first 20 odd natural numbers.

        Console.WriteLine("Program to find the sum of first 20 odd natural numbers");
        int sum = 0;
        int value = 20;

        for (int i = 1; i<=value*2; i= i+2)
        {
            sum = sum + i;  

        }

        Console.WriteLine($"Sum of first 20 odd natural numbers is: {sum}");

    }


    static void Main3()
    {
        //Task 3 - Write a program in C# to read 5 numbers from keyboard and find their sum and average.

        Console.WriteLine("Program in C# to read 5 numbers from keyboard and find their sum and average");
        int [] Numbers = new int[5];
        int sum = 0;
        int average = 0;

        try
        {


            Console.WriteLine("Enter the first integer number");
            Numbers[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer number");
            Numbers[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third integer number");
            Numbers[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth integer number");
            Numbers[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth integer number");
            Numbers[4] = int.Parse(Console.ReadLine());


            for (int i = 0; i < Numbers.Length; i++)
            {
                sum = sum + Numbers[i];
            }

            average = sum / Numbers.Length;

            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"Average is: {average}");
        }
        catch 
        {
            Console.WriteLine("Please restart the program and enter the numbers only integer type");
        }

    }

    static void Main4(string[] args)
    {

        //Task 4 - Write a program in C# to display the multiplication table vertically from 1 to n.

        Console.WriteLine("Program in C# to display the multiplication table vertically from 1 to n.");
        int uptoTable;
        Console.WriteLine("Enter the number for multiplication table");
        try
        {
            uptoTable = int.Parse(Console.ReadLine());
            Console.WriteLine("THE MULTIPLICATION TABLE: ");

            for (int j = 1; j <= 10; j++)
            {

                for (int i = 1; i <= uptoTable; i++)
                {
                    Console.Write($"{i}*{j}={i * j}, ");

                }
                Console.WriteLine();
            }


        }
        catch 
        {
            Console.WriteLine("Please restart the program and enter the numbers only integer type");
        }
    }

    static void Main5()
    {
        //Task 5 - Write a program in C# to display the pattern like right angle triangle using an asterisk.

        Console.WriteLine("Program in C# to display the pattern like right angle triangle using an asterisk");
        Console.WriteLine("Enter the number for triangle:");
        int Triangesize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("THIS IS YOUR TRIANGLE:");
        
    for (int i=1; i<=Triangesize; i++)
        {
            for(int j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine() ;
        }

    }

    static void Main6(string[] args)
    {
        //Task 6 - Write a program in C# to make such a pattern like right angle triangle with number increased by 1.
        Console.WriteLine("program in C# to make such a pattern like right angle triangle with number increased by 1");
        Console.WriteLine("Enter the number for triangle size:");
        int size = Convert.ToInt32(Console.ReadLine());
        int k=1;
        int j; 
        for (int i=1; i<=size; i++)
        {
            for( j=1; j<=i; j++)
            {
              Console.Write(k);
                k++;
              
            }
           
            Console.WriteLine() ;
           
        }
      
    }


    static void Main7()
    {
        //Task 7 - Write a program in C# to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
        Console.WriteLine("Program in C# to display the sum of the series [ 9 + 99 + 999 + 9999 ...]");
        Console.WriteLine("Enter the series size:");
        int SeriesSize = Convert.ToInt32(Console.ReadLine());
        int nine = 9;
        int Sum = 0;
       
            for (int i = 1; i <= SeriesSize; i++)
            {
            Sum += nine;
                Console.Write(nine);
            nine = nine * 10 + 9;
            Console.Write(" ");


             }
            Console.WriteLine();
           Console.WriteLine($"The Sum is: {Sum}");
            
    }
       
       static void Main(string[] args)
    {
        //Task 8 - Write a C# program to find prime numbers up to users entered value. 

        Console.WriteLine("Program for to find prime numbers up to users entered value");
        Console.WriteLine("Enter the upper limit:");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        for (var i = 2; i <= num; i++)
        {

            for (var j = 2; j <= num; j++)
            {
                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.Write(i + ",");
            }
            isPrime = true;

        }

    }


    













}























