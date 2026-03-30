// while loop

int count = 0;
while (count < 10)
{
    Console.WriteLine("I love programming - 1");
    count++;
}

//for loop

for(int i=0; i<10; i++)
{
    Console.WriteLine("I love programming - 2");
}

// do while loop

int j = 0;
do
{
    Console.WriteLine("I love programming - 3");
    j++;
}
while (j < 10);

//nested loop

for (int row = 1; row <= 3; row++)
{
    Console.WriteLine($"Row {row}:");

    for (int student = 1; student <= 4; student++)
    {
        Console.WriteLine($"  Student {student} - Present!");
    }

    Console.WriteLine();  
}

Console.WriteLine("Roll call complete!");