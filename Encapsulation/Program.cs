/*public class Student
{
    private string name;
    private int roll;
    private double banglaMark;
    private double englishMark;

    public Student(string name, int roll, double banglaMark, double englishMark)
    {
        this.name = name;
        this.roll = roll;
        this.banglaMark = banglaMark;
        this.englishMark = englishMark;
    }

    public string getName()
    {
        return name;
    }

    public int getRoll()
    {
        return roll;
    }

    public double getBanglaMark()
    {
        return banglaMark;
    }

    public void setBanglaMark(double banglaMark)
    {
        if (banglaMark >= 0 && banglaMark <= 100)
        {
            this.banglaMark = banglaMark;
        }
        else
        {
            Console.WriteLine("Error: Mark must be between 0 to 100!");
        }
    }

    public double English
    {
        get { return englishMark; }
        set
        {
            if(value >= 0 && value <= 100)
            {
                englishMark = value;
            }
            else
            {
                Console.WriteLine("Error: Mark must be between 0 t0 100!");
            }
        }
    }

}
*/

public class BankAccount
{
    private string ownerName;
    private double balance;

    public BankAccount(string ownerName, double balance)
    {
        this.ownerName = ownerName;
        this.balance = balance;
    }

    public string Name
    {
        get {  return ownerName; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public void deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount} টাকা জমা হলো। বর্তমান Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Error: জমার পরিমাণ 0-এর বেশি হতে হবে!");
        }
    }

    public void withdraw(double amount) { 
        if(amount <= 0)
        {
            Console.WriteLine("Error: তোলার পরিমাণ 0-এর বেশি হতে হবে!");
        }

        else if(amount > balance)
        {
            Console.WriteLine($"Error: পর্যাপ্ত balance নেই! বর্তমান Balance: {balance}");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"{amount} টাকা তোলা হলো। বর্তমান Balance: {balance}");
        }
    }

}

class Encapsulation
{
    static void Main(string[] args)
    {
        /*Student arafath = new Student ("Arafath", 146, 75.0, 70.0);

        Console.WriteLine(arafath.getName());

        arafath.setBanglaMark(-1);
        arafath.English = -2;*/

        BankAccount account = new BankAccount("Arafath", 5000);

        Console.WriteLine(account.Name);
        Console.WriteLine(account.Balance);

        account.deposit(3000);

        account.withdraw(account.Balance);


    }
}
