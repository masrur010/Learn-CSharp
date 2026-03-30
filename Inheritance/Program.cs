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

    public void printInfo()
    {
        Console.WriteLine($"Name: {name}, Id: {id}");
    }

}

public class Student : Person
{
    public double marks;

    public Student(string name, int id, double marks) : base(name, id)
    {
        this.marks = marks;
    }

    public string getGrade()
    {
        if (marks >= 80) return "A+";
        else if (marks >= 60) return "A";
        else if(marks >= 40) return "B";
        else return "F";
    }
}

public class Teacher : Person
{
    public string subject;

    public Teacher(string name, int id,  string subject) : base(name, id)
    {
        this.subject = subject;
    }

    public string getTitle()
    {
        return $"{name} Sir ({subject})";
    }
}

public class Inheritance
{
    static void Main(string[] args)
    {
        Student arafath = new Student("Arafath", 146, 85);
        Teacher Sajjad = new Teacher("Sajjad", 201, "Programming");

        arafath.printInfo();
        Console.WriteLine(arafath.marks);
        Console.WriteLine(arafath.getGrade());

        Console.WriteLine("---");

        Sajjad.printInfo();
        Console.WriteLine(Sajjad.subject);
        Console.WriteLine(Sajjad.getTitle());

    }
}