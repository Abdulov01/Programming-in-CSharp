class program
{


    //Task1 url - https://www.exercisescsharp.com/oop/first-class-method-tostring
    static void Main1()
    {

        Console.WriteLine("Please enter the names:");
        Person[] persons = new Person[3];
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = new Person()
            {
                name = Console.ReadLine()
            };

        }

        for (int i = 0; i < persons.Length; i++)
        {
            Console.WriteLine($"Hello! My name is {persons[i].name}");
        }




    }


    public class Person
    {
        public string name;
    }


    //Task2 url - https://www.exercisescsharp.com/oop/constructors-destructors

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the names:");


        Person1[] persons = new Person1[3];

        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = new Person1(Console.ReadLine());

        }

        for (int i = 0; i < persons.Length; i++)
        {
            Console.WriteLine($"Hello! My name is {persons[i].name}");

        }

    }


    class Person1
    {
        public string name;
        public Person1(string name)
        {
            this.name = name;
        }

        ~Person1()
        {
            name = string.Empty;
        }

    }


}



