
//initialize

using System.Collections;
using System.Drawing;

int[] marks = { 85, 90, 78, 92, 88 };
int[] value = new int[] { 85, 90, 78, 92, 88 };

Console.WriteLine("Array size: " + marks.Length);
Console.WriteLine("Array size: " + value.Length);

Array.Reverse(marks);
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}
/*
//multi-dimensional array initialization

int[,] seats = new int[5, 8];

seats[0, 0] = 1;
seats[0, 1] = 1;
seats[2, 5] = 1;

int[,] matrix = new int[3, 4]
{
    { 1, 2, 3, 4 },       // Row 0 এর সব values
    { 5, 6, 7, 8 },       // Row 1 এর সব values
    { 9, 10, 11, 12 }     // Row 2 এর সব values
};*/

// Outer loop: Row গুলোর জন্য
/*for (int row = 0; row < matrix.GetLength(0); row++)
{
    // Inner loop: Column গুলোর জন্য
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col] + "\t");
    }

    Console.WriteLine();  // প্রতি row এর পর new line
}
*/
//3d array

/*Console.WriteLine("🏢 BUILDING LIGHT STATUS");
Console.WriteLine("═══════════════════════════════════════\n");

// 0 = Light OFF, 1 = Light ON
int[,,] building = new int[2, 3, 2]  // 2 floors, 3 rooms, 2 lights
{
    {   // Floor 0
        { 1, 0 },   // Room 0: Light0 ON, Light1 OFF
        { 0, 0 },   // Room 1: Both OFF
        { 1, 1 }    // Room 2: Both ON
    },
    {   // Floor 1
        { 0, 1 },   // Room 0: Light0 OFF, Light1 ON
        { 1, 1 },   // Room 1: Both ON
        { 0, 0 }    // Room 2: Both OFF
    }
};*/

// 3 টা nested loop!
/*for (int floor = 0; floor < building.GetLength(0); floor++)
{
    Console.WriteLine($"🏢 Floor {floor}:");
    Console.WriteLine("   ─────────────────────────────────");

    for (int room = 0; room < building.GetLength(1); room++)
    {
        Console.Write($"   🚪 Room {room}: ");

        for (int light = 0; light < building.GetLength(2); light++)
        {
            if (building[floor, room, light] == 1)
            {
                Console.Write("💡 ");  // ON
            }
            else
            {
                Console.Write("⬛ ");  // OFF
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Statistics
int totalLights = building.Length;
int lightsOn = 0;

for (int f = 0; f < building.GetLength(0); f++)
{
    for (int r = 0; r < building.GetLength(1); r++)
    {
        for (int l = 0; l < building.GetLength(2); l++)
        {
            if (building[f, r, l] == 1)
            {
                lightsOn++;
            }
        }
    }
}

Console.WriteLine($"📊 Summary: {lightsOn} out of {totalLights} lights are ON");*/


//foreach loop

//একই element একাধিকবার থাকলে শেষেরটার index পেতে এই Array.LastIndexOf() use করো।

string[] fruits = { "Apple", "Banana", "Mango", "Orange", "Grape" };

Array.Sort( fruits );
int index = Array.IndexOf(fruits, "Apple");

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("index: " + index);

//2d
/*
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5, 6 };
jaggedArray[2] = new int[] { 7, 8, 9 };

// Nested foreach দিয়ে traverse
foreach (int[] row in jaggedArray)
{
    foreach (int num in row)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();  // প্রতি row এর পর new line
}*/

// Copy array

int[] source = { 10, 20, 30, 40, 50 };
int[] destination = new int[5];  // Empty array, same size

Console.WriteLine("Source array:");
foreach (int num in source)
{
    Console.Write(num + " ");
}

Console.WriteLine("\n\nDestination array (before copy):");
foreach (int num in destination)
{
    Console.Write(num + " ");  // সব 0 থাকবে
}

// Copy করো - সব 5 টা element
Array.Copy(source, destination, 5);

Console.WriteLine("\n\nDestination array (after copy):");
foreach (int num in destination)
{
    Console.Write(num + " ");
}

//clear array

int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine("Before Clear:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

// Index 1 থেকে 3 টা element clear করো
Array.Clear(numbers, 1, 3); 

Console.WriteLine("\n\nAfter Clear (index 1 to 3):");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

//array exists

int[] marks2 = { 85, 92, 45, 78, 33 };

// কোনো fail marks (40 এর নিচে) আছে কিনা?
bool hasFailed = Array.Exists(marks2, mark2 => mark2 < 40); //mark => mark < 40 এটাকে বলে Lambda Expression।

if (hasFailed)
{
    Console.WriteLine("❌ Some students have failed!");
}
else
{
    Console.WriteLine("✅ All students passed!");
}

//Array find

int firstFail = Array.Find(marks2, mark => mark < 40);

Console.WriteLine($"First failing mark: {firstFail}");



/*
Array.Sort(arr) ছোট থেকে বড় সাজানো	Array.Sort(numbers);
Array.Reverse(arr)  উল্টানো Array.Reverse(numbers);
Array.IndexOf(arr, item)    প্রথম occurrence এর index	Array.IndexOf(names, "Rahim");
Array.LastIndexOf(arr, item)    শেষ occurrence এর index	Array.LastIndexOf(nums, 30);
Array.Copy(src, dest, count)    Copy করা    Array.Copy(a, b, 5);
Array.Clear(arr, start, count)  মুছে ফেলা(default করা) Array.Clear(nums, 0, 3);
Array.Resize(ref arr, newSize)  Size বদলানো Array.Resize(ref nums, 10);
Array.Exists(arr, condition)    Condition match আছে কিনা	Array.Exists(marks, m => m < 40);
Array.Find(arr, condition)  প্রথম match element	Array.Find(marks, m => m < 40);
Array.FindAll(arr, condition)   সব match elements	Array.FindAll(marks, m => m < 40);
Array.FindIndex(arr, condition) প্রথম match এর index	Array.FindIndex(marks, m => m < 40);
Array.FindLastIndex(arr, condition) শেষ match এর index	Array.FindLastIndex(marks, m => m < 40);

*/


