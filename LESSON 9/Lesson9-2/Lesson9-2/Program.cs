

//Task3 url - https://www.exercisescsharp.com/oop/class-person-student-and-teacher

class StudentProfessorTest

{

    static void Main()
    {

        Person newPerson = new Person();
        newPerson.Greet();

        Student newStudent = new Student();
        newStudent.SetAge(22);
        newStudent.Greet();
        newStudent.ShowAge();
        newStudent.Study();

        Professor newProfessor = new Professor();
        newProfessor.SetAge(52);
        newProfessor.Greet();
        newProfessor.Explain();


    }





}



public class Person
{

    public int Age;
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int age)
    {

        Age = age;
    }


}


class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I am studying ");
    }

    public void ShowAge()
    {

        Console.WriteLine($"My age is: {Age} years old.");
    }

}


class Professor : Person
{
    public void Explain()
    {
        Console.WriteLine("I am explaining");
    }

}