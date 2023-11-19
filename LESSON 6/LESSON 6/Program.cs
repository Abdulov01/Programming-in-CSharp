
using System.Security.Cryptography;
using System.Linq;

class Program
{
    static void Main1(string[] args)
    {
        //Task (1-3) - Enter the value between 10 and 100. Initialize int array with random values with length of user entered value

        int arraySize;
        Random random = new Random();

        Console.WriteLine("Enter the integer number for array size");
        arraySize = int.Parse(Console.ReadLine());

        int[] randomArray = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            randomArray[i] = random.Next(10, 100);
        }

        for (int j = 0; j < arraySize; j++)
        {

            Console.WriteLine(randomArray[j]);
        }

        //Task 1 - Write a program in C# sort array both descending and ascending order

        Array.Sort(randomArray);
        Console.WriteLine("Ascending Array: ");
        foreach (int k in randomArray)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Descending Array: ");
        Array.Reverse(randomArray);
        foreach (int k in randomArray)
        {
            Console.Write(k + " ");
        }
        Console.WriteLine() ;



        //Task 2 - Write a C# program to find the 3rd max element of array.

        Console.WriteLine($"The 3rd max element in array is: {randomArray[2]}");

        //Task 3 - Write a program in C# to find first 4 max elements.

        int[] first4Max = new int[4];

        for (int i = 1 ;i <= first4Max.Length; i++)
        {
            first4Max[i-1] = randomArray[i-1];

        }
        Console.WriteLine("First 4 max element in the array are: ");
        foreach(int k in first4Max)
        {
            Console.WriteLine(k + " "); 
        }

    }
    static void Main2(string[] args)
    {
        //Task 4 - Write a program in C# to create a function to swap the values of two integer numbers without additional variable.
        //Test Data : Enter a number: 5 Enter another number: 6 Expected Output : Now the 1st number is : 6 , and the 2nd number is : 5

        int a;

        int b;

        Console.WriteLine("Enter the first integer number:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer number:");
        b = Convert.ToInt32(Console.ReadLine());


        (a, b) = (b, a);

        Console.WriteLine($"Now the first number is: {a} The second number is: {b}");


    }





    //Task 5 - Write a program in C# to create a function to display the n number Fibonacci sequence.

    static void Main3(string[] args)
    {
        int n;

        Console.WriteLine("Enter the integer number for fibonachi series: ");
        n = int.Parse(Console.ReadLine());

        int[] fibonachiNumbers = new int[n];

        fibonachiNumbers[0] = 0;
        fibonachiNumbers[1] = 1;

        for (int i = 2; i < fibonachiNumbers.Length; i++)
        {
            fibonachiNumbers[i] = fibonachiNumbers[i - 1] + fibonachiNumbers[i - 2];
        }
        Console.WriteLine("Your fibonachi numbers are: ");
        foreach (int i in fibonachiNumbers)
        {
            Console.Write(i + " ");

        }

    }


    static void Main4()
    {
        //Task 6 - Write a program in C# to create a function to calculate the sum of the individual digits of a given number
        int number;
        int sum = 0;
        int divideResult;
        Console.WriteLine("Enter the integer number: ");

        number = Convert.ToInt32(Console.ReadLine());

       while (number > 0)
        {
            divideResult = number % 10;
            sum += divideResult;
            number = number / 10;

        }
       
       Console.WriteLine($"The sum of the digits of the number = {sum}");

    }

    static void Main(string[] args)
    {
        //Task 7 - Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
        int count = 0;
        string data;
        Console.WriteLine("Program for to count number of spaces are in the string");
        Console.WriteLine(" ");
        Console.WriteLine("Enter your string data: ");

        data = Console.ReadLine();
        
        for (int i = 0; i<data.Length; i++)
        {
            if (data[i] == ' ')
            {
                count += 1;
            }

        }

       Console.WriteLine($"The number of spaces in this text = {count}");


    }


























}