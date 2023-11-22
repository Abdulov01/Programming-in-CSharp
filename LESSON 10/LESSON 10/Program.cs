


using System.Security.Cryptography.X509Certificates;

/* 

Create a SchoolPerson class that has SchoolName, Name, Surname, Age and DateOfBirth, CurrentClass properties. 
Also this class will have a general Greet method, which will show us "Hello {Name Surname}".

Create a class "Student" and another class "Teacher", both descendants of "SchoolPerson" class. 
"SchoolPerson" will have a method calles "GoToClasses" and when calling this method it will show us "Inside Base GoToClasses method"

The class "Student" will also have a public method "GoToClasses", 
which will write on screen "I’m {name surname}, I am student and I'm going to class."

The class "Teacher" will have a public method "Explain", 
which will show on screen "Explanation begin on subject {subject}". 
Also, it will have a private attribute "subject", a string which indicates his/her speciality. 
Also "Teacher" will have a public method "GoToClasses", which will write on screen "I’m {name surname}, I am a teacher."

The class SchoolPerson must have a functionality to set of their age (eg, 20 years old). 
Note: Age cannot be less than 6 and more than 50. If we try to assign invalid number exception should be thrown.

The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).

You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
Create a SchoolPerson and make it say hello
Create a student, set his age to 21, tell him to Greet, display his age and make him to go classes
Create a teacher, set age to 30 years old, ask him to say hello, then go to classes and then explain.

*/


class StudentAndTeacherTest
{
    static void Main(string[] args)
    {
        SchoolPerson SchoolPerson = new SchoolPerson();
        SchoolPerson.Greet();

        Console.WriteLine();

        Student student = new Student("Shadoghlan", "Abdulov" );
        student.SetAge(7);
        student.Greet();
        student.ShowAge();
        student.GoToClasses();

        Console.WriteLine();

        Teacher teacher = new Teacher("Nurlan" , "Valizade");
        teacher.SetAge(30);
        teacher.Greet();
        teacher.GoToClasses();
        teacher.Explain();
    }
}



class SchoolPerson
{
    string SchoolName;
    public string Name;
    public string Surname;
    public int Age;
    int DateOfBithday;


    public void Greet()
    {
        Console.WriteLine("Hello " + Name +" " + Surname );

    }

    virtual public void GoToClasses()
    {
        Console.WriteLine("Inside Base GoToClasses method");
    }

    virtual public void SetAge(int age)
    {
        if (age < 6 || age > 50) 
        {
            throw new Exception("Invalid age ");
        }
      
        

    } 
}

class Student : SchoolPerson
{
    public Student(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    

    public override void SetAge(int age)
    {
        base.SetAge(age);
       Age = age;
        
            }

    public override void GoToClasses()
    {
        Console.WriteLine("I am " + Name + " " + Surname +"."+ "I am student and I'm going to class.");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is: " + Age + " years old");    
    }
}

class Teacher : SchoolPerson   
{
    public Teacher(string name, string surname)
    { 
            Name = name;
            Surname = surname;
    }



    private string subject = "Programming";
    public void Explain()
    {
        Console.WriteLine("Explanation begin on subject " + subject);
    }

    public override void GoToClasses()
    {
        Console.WriteLine("I am " + Name+ " "+ Surname + " I am a Teacher");
    }

    public override void SetAge(int age)
    {
        base.SetAge(age);
        Age = age;
    }
    public void ShowAge()
    {
        Console.WriteLine("My age is: " + Age + " years old");
    }
}




