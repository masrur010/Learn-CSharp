//Addition 

int bangla = 75;
int english = 82;
int math = 90;
int science = 88;

int total = bangla + english + math + science;

Console.WriteLine($"Total marks: {total}");  // 335 

//Substitution

int stock = 100;

stock = stock - 15;
Console.WriteLine($"Stock: {stock}");  // 85

stock = stock - 23;
Console.WriteLine($"Stock: {stock}");  // 62

//Multiplication

int monthlySalary = 35000;
int months = 12;

int yearlySalary = monthlySalary * months;

Console.WriteLine($"Yearly salary: {yearlySalary} taka");  // 420000

//Division

int totalBill = 500;
int friends = 3;

double perPerson = 1.0 * totalBill / friends;

Console.WriteLine($"Matha pichu: {perPerson} taka");  // 100

//Reminder

int number = 15;

int remainder = number % 2;

if (remainder == 0)
{
    Console.WriteLine($"{number} jor");
}
else
{
    Console.WriteLine($"{number} bijor");  // এটা print হবে
}


//Operator precedence:
//PEDMAS --> Parentheses, Exponents, Multiplication/Division, Addition/Subtraction
//BODMAS --> Bracket, of, Division, Multiplication, Addition and Subtraction

//Compare

int secretNumber = 7;
int guess = 7;

bool correct = guess == secretNumber;

Console.WriteLine($"Correct guess? {correct}");  // True

int a = 5;
int b = 5;

bool result = a != b;

Console.WriteLine(result);  // False 

bool result2 = a > b;

Console.WriteLine(result2);  // False

bool result3 = a >= b;

Console.WriteLine(result3);  // True 

//Logical Operator

bool hasMoney = true;
bool hasTime = true;

bool canGoMovie = hasMoney && hasTime;

Console.WriteLine(canGoMovie);  // True

bool isLoggedIn = false;

bool notLoggedIn = !isLoggedIn;

Console.WriteLine($"Not logged in? {notLoggedIn}");  // True

string name = "";

bool isEmpty = name == "";
bool hasValue = !isEmpty;

Console.WriteLine($"Is empty? {isEmpty}");    // True
Console.WriteLine($"Has value? {hasValue}");  // False