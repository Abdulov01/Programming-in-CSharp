


//LESSON 4
//Task 1 - Write a C# that calculates the day of week (ex: Monday) of your birthday

using System.Runtime.CompilerServices;

DateTime MyBirthday = new DateTime(2001,11,18);

Console.WriteLine ($"My birthday is {MyBirthday.ToString("dd.MM.yyyy")}");

var DayOfWeek = MyBirthday.DayOfWeek;
Console.WriteLine($"The day of week of my birthday is {DayOfWeek.ToString()}");



//Task 2 - Write a C# that calculates you current life days (how many days past since your birth)

DateTime CurrentDate = DateTime.Now;
var Mylife = CurrentDate.Subtract(MyBirthday);
Console.WriteLine($"The number of days I live are {Mylife.Days}");


//Task 3 - Write a C# program to calculate what day of the week is after 40 days from this moment

DateTime AfterDay = CurrentDate.AddDays(40);
Console.WriteLine("After 40 days from this moment day of week is " + AfterDay.DayOfWeek.ToString());



//Task 4 - Write a program in C# to check whether the given year, month and day are the current or not. 


 
Console.WriteLine("#### - Program for to check whether the given year, month and day are the current or not");
Console.WriteLine("Type the your date! Exp: dd.MM.yyyy");

try
{
    DateTime GivenData = DateTime.Parse(Console.ReadLine());

    CurrentDate = DateTime.Parse(CurrentDate.ToShortDateString()); //Convert the time format only date (Not Time information)
    CurrentDate.ToString("dd.MM.yyyy");

    if (GivenData == CurrentDate)
    {
        Console.WriteLine("The date you wrote is the same as the current date");
    }
    else
    {
        Console.WriteLine("The date you wrote is NOT the same as the current date");

    }
    Console.WriteLine($"The current date is: {CurrentDate.ToString()}");


}
catch
{
    Console.WriteLine("Please restart the program and type the date only this format: dd.MM.yyyy");
}






//Task 5 - Write a program in C# to get the day of week from last day of the current year against a given date


Console.WriteLine("#### - Program for to get the day of week from last day of the current year against a given date");
Console.WriteLine("Type the date you want in this format: dd.MM.yyyy");

try
{
    DateTime GivenDate2 = DateTime.Parse(Console.ReadLine());

    DateTime LastDayOfYear = new DateTime(GivenDate2.Year + 1, 1, 1);

    LastDayOfYear = LastDayOfYear.AddDays(-1);

    DayOfWeek = LastDayOfYear.DayOfWeek;

    Console.WriteLine($"The day of week from last day of given date is : {DayOfWeek.ToString()}");

}
catch
{
    Console.WriteLine("Please restart the program and type the date only this format: dd.MM.yyyy");
}





/*
  Task 6 - Write a program in C# Sharp to find the last day of a week against a given date. Test Data:
Input the Day : 16
Input the Month : 06
Input the Year : 2016

Expected Output :
The formatted Date is : 16 / 06 / 2016 The last day of the week for the above date is: 18 / 06 / 2016
*/


Console.WriteLine("#### - Program for to find the last day of a week against a given date");
Console.WriteLine("Type the date in this format: dd.MM.yyyy");

try
{
    DateTime GivenDate3 = DateTime.Parse(Console.ReadLine());

    while (GivenDate3.DayOfWeek != DayOfWeek.Sunday)


    {
        GivenDate3 = GivenDate3.AddDays(1);



    }

    Console.WriteLine($"The last day of the week for the above date is: {GivenDate3}");
}
catch 
{
    Console.WriteLine("Please restart the program and type the date only this format: dd.MM.yyyy");
}









//Task 7 - Write a C# Sharp program to find the largest of three numbers


long[] Numbers = new long[3];
Console.WriteLine("#### - Program for to find the largest of three numbers");

try
{

    Console.WriteLine("Type first number");
    Numbers[0] = long.Parse(Console.ReadLine());

    Console.WriteLine("Type second number");
    Numbers[1] = long.Parse(Console.ReadLine());

    Console.WriteLine("Type third number");
    Numbers[2] = long.Parse(Console.ReadLine());



    Console.WriteLine($"The largest number of yours is: {Numbers.Max()}");
}

catch
{
    Console.WriteLine("Please restart the program and enter number only");
}




//Task 8 - Write a program in C# Sharp to read any day number in integer and display day name in the word

Console.WriteLine("#### - Program for to read any day number in integer and display day name in the word");

Console.WriteLine("Enter the day to know what day of the week it is:");


try
{
    int Day = int.Parse(Console.ReadLine());


    switch (Day)
    {
        case 1:
            Console.WriteLine("This day is MONDAY");
            break;

        case 2:
            Console.WriteLine("This day is TUESDAY");
            break;

        case 3:
            Console.WriteLine("This day is WEDNESDAY");
            break;

        case 4:
            Console.WriteLine("This day is THURSDAY");
            break;

        case 5:
            Console.WriteLine("This day is FRIDAY");
            break;

        case 6:
            Console.WriteLine("This day is SATURDAY");
            break;

        case 7:
            Console.WriteLine("This day is SUNDAY");
            break;

        default:
            Console.WriteLine("Invalid day number!!!");
            break;

    }
}
catch
{
    Console.WriteLine("Please restart the program and enter number only");
}









