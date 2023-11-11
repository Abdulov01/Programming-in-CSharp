// See https://aka.ms/new-console-template for more information



//Task 1 - Write a C# program that takes two numbers as input and returns true or false when both numbers are even or odd

/*using System;

byte a;
byte b;


Console.WriteLine("type the first number");
a = byte.Parse(Console.ReadLine());

Console.WriteLine("type the second number");
b = byte.Parse(Console.ReadLine());

var a_numbereven = a % 2;
var b_numbereven = b % 2;
bool resulteven = a_numbereven == 0 && b_numbereven == 0;
bool resultodd = a_numbereven != 0 && b_numbereven != 0;

if (resulteven == true)
{
    Console.WriteLine("Your numbers both are even");
}
else if (resultodd == true)
{
    Console.WriteLine("Your numbers both are odd");
}
else
{
    Console.WriteLine("Your numbers both neither even nor odd");
}
*/


//Task 2 - Write a C# program which takes 2 string input from user and return if second string is in first string.

/*Console.WriteLine("Type the first text");

string text1 = Console.ReadLine();


Console.WriteLine("Type the second text");

string text2 = Console.ReadLine();

bool result = text1.Contains(text2);
Console.WriteLine(result);
text1 = text1.ToUpper();
Console.WriteLine(text1);
*/





//Task 3 - Get 2 int number input from user and calculate the exact input1 / input2. Example: 16, 5. Result should be 3.2 not 3.

    int first;
    int second;


    Console.WriteLine("Type the firs number");
    first = int.Parse(Console.ReadLine());

    Console.WriteLine("Type the second number");
    second = int.Parse(Console.ReadLine());

    Console.WriteLine((double)first / second);


  




 