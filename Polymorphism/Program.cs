using System;

public class Person
{
    public string name;
    public int id;

    public Person(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public virtual void printInfo()
    {
        Console.WriteLine($"Name: {name}, ID: {id}");
    }

    public void printInfo(bool showDetailed)
    {
        if (showDetailed)
        {
            Console.WriteLine($"[DETAILED] Name: {name}, ID: {id}, Type: Person");
        }
        else
        {
            Console.WriteLine($"Name: {name}, ID: {id}");
        }
    }

}


public class Student : Person
{
    public double marks;

    public Student(string name, int id, double marks) : base(name, id)
    {
        this.marks = marks;
    }

    public override void printInfo()
    {
        Console.WriteLine($"Name: {name}, ID: {id}, Marks: {marks}");
    }
}

public class Teacher : Person
{
    public string subject;

    public Teacher(string name, int id, string subject) : base(name, id)
    {
        this.subject = subject;
    }

    public override void printInfo()
    {
        Console.WriteLine($"Name: {name}, ID: {id}, Subject: {subject}");
    }
}
public class Polymorphism
{
    static void Main(string[] args)
    {

        //runtime polymorphism
        Person[] people = new Person[] {
            new Student("Arafath", 146, 85),
            new Teacher("Sajjad", 201, "Programming"),
            new Student("Shihab", 102, 92)
        };

        foreach(Person person in people)
        {
            person.printInfo();
            Console.WriteLine("-----");
        }

        //compile time polymorphism

        Person uthsob = new Person("Uthsob", 621);

        uthsob.printInfo();
        uthsob.printInfo(true);

    }
}