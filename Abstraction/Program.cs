public abstract class Person
{
    public string name;
    public int id;

    public Person(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public abstract void printInfo();
}

public class Student : Person
{
    public double marks;

    public Student(string name, int id, double marks):base(name, id){
        this.marks = marks;
    }

    public override void printInfo()
    {
        Console.WriteLine($"Name = {name} ID = {id} Marks = {marks}");
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
        Console.WriteLine($"Name = {name} ID = {id} Subject = {subject}");
    }
}

public class Abstraction
{
    static void Main(string[] args)
    {
        Person[] person = new Person[]
        {
            new Student("Rahim", 101, 85),
            new Teacher("Karim", 201, "Mathematics")
        };

        foreach (Person p in person)
        {
            p.printInfo();
        }
    }
}