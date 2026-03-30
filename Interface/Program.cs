public interface IPerson
{
    public void printInfo();
}

public class Student : IPerson
{
    public string name;
    public int id;
    public double marks;

    public Student(string name, int id, double marks)
    {
        this.name = name;
        this.id = id;
        this.marks = marks;
    }

    public void printInfo()
    {
        Console.WriteLine($"Name - {name} ID - {id} Marks - {marks}");
    }
}

public class Teacher : IPerson
{
    public string name;
    public int id;
    public string subject;

    public Teacher(string name, int id, string subject)
    {
        this.name = name;
        this.id = id;
        this.subject = subject;
    }

    public void printInfo()
    {
        Console.WriteLine($"Name - {name} ID - {id} Subject - {subject}");
    }
}

public class Interface
{
    static void Main(string[] args)
    {
        IPerson[] person = new IPerson[] {
            new Student("Arafath", 146, 85),
            new Teacher("Sajjad", 201, "Programming")
        };

        foreach (IPerson p in person) {
            p.printInfo();
        }

    }
}