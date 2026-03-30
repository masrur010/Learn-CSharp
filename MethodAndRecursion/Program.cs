
void sayHello()
{
    Console.WriteLine("Hello");
}

sayHello();


// String

string name = "  Rahim  ";
string upperName = name.ToUpper();  // নতুন string এ রাখো

Console.WriteLine(name);       // Rahim (original same)
Console.WriteLine(upperName);  // RAHIM (নতুন string)
string lower = name.ToLower();

Console.WriteLine(lower);  // rahim

string trimStart = name.Trim();
Console.WriteLine(trimStart);

string sentence = "I love programming in C#";

Console.WriteLine(sentence.Contains("love"));         // True
Console.WriteLine(sentence.Contains("Java"));         // False

Console.WriteLine(sentence.StartsWith("report"));    //false
Console.WriteLine(sentence.EndsWith("C#"));    //true

Console.WriteLine(sentence.IndexOf("love"));     // 2
Console.WriteLine(sentence.IndexOf("C#"));       // 22

string result = sentence.Substring(6);        // programming in C#
string result2 = sentence.Substring(0,6);        // I love
Console.WriteLine(result);
Console.WriteLine(result2);

string text = "I love Java";

string result3 = text.Replace("Java", "C#");
Console.WriteLine(result);  // I love C#


string text2 = "This is a bad word. That damn thing is stupid.";
string[] badWords = { "bad", "damn", "stupid" };

Console.WriteLine($"Original: {text}\n");

string censored = text2;

foreach (string word in badWords)
{
    // Bad word কে **** দিয়ে replace করো
    string replacement = new string('*', word.Length);
    censored = censored.Replace(word, replacement);
}

Console.WriteLine($"Censored: {censored}");

string[] text3 = text2.Split(" ");

foreach(string txt in text3)
{
    Console.WriteLine(txt);
}

string res = string.Join(" ", text2);
Console.WriteLine(res);

string txtIn = text.Insert(11, "/c#");

Console.WriteLine(txtIn);

string[] names = { "Rahim", "Karim", "Jabbar" };
int[] marks = { 85, 92, 78 };

Console.WriteLine("Name       Marks");
Console.WriteLine("─────────────────");

for (int i = 0; i < names.Length; i++)
{
    // -10 মানে left align, 10 characters wide
    // 5 মানে right align, 5 characters wide
    Console.WriteLine($"{names[i],-10} {marks[i],0}");
}

static void Swap(ref int a, ref int b)
{
    Console.WriteLine($"   Inside Swap (before): a = {a}, b = {b}");

    int temp = a;
    a = b;
    b = temp;

    Console.WriteLine($"   Inside Swap (after): a = {a}, b = {b}");
}

 Console.WriteLine("🔄 SWAP EXAMPLE\n");

    int x = 10;
    int y = 20;

    Console.WriteLine($"Before Swap: x = {x}, y = {y}");
    Console.WriteLine();

    Console.WriteLine("Calling Swap...");
    Swap(ref x, ref y);
    Console.WriteLine();

    Console.WriteLine($"After Swap: x = {x}, y = {y}");

static int Factorial(int n)
{
    // Base Case
    if (n <= 1)
    {
        return 1;
    }

    // Recursive Case: n! = n × (n-1)!
    int smallerResult = Factorial(n - 1);  // Divide: ছোট problem solve করো
    int result = n * smallerResult;         // Merge: combine করো

    return result;
}

Console.WriteLine($"5! = {Factorial(5)}");  // 120