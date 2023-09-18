int[] numbers = new[] {10, -2, 94, 32, 1005, 234, 2, 3, 1, 67, -37, 100, -26};

//First Task.

int[] positiveNums = 
    (from nums in numbers
    where nums > 0
    select nums).ToArray();

foreach (int item in positiveNums)
    Console.WriteLine("Positive numbers: " + item);

//Second Task.

int[] oddNums =
    (from nums in numbers
    where nums % 2 == 1
    select nums).ToArray();

foreach (int item in oddNums)
    Console.WriteLine("Odd numbers: " + item);

//Third Task.

int[] evenNegativeNums =
    (from nums in numbers
    where nums % 2 == 0 && nums < 0
    select nums).ToArray();

foreach (int item in evenNegativeNums)
    Console.WriteLine("Even negative numbers: " + item);

//Fourth Task.

int[] positiveTwoDigitNums = 
    (from nums in numbers
    where nums > 0 && nums < 99 
    select nums).ToArray();

foreach (int item in positiveTwoDigitNums)
    Console.WriteLine("Positive two digit numbers: " + item);

//Fifth Task.

string[] str = new[] {"Hello", "School", "Goods", "Academy", "Dotnet", "Garden", "Google", "OlaF"};

string[] editedStr =
    (from strs in str
    where strs.StartsWith("G") && strs.Length > 5
    select strs).ToArray();

foreach (string item in editedStr)
    Console.WriteLine(item);

//Sixth Task.

string[] editedStr1 =
    (from strs in str
    where strs.EndsWith("F") && strs.Length < 5
    select strs).ToArray();

foreach (string item in editedStr1)
    Console.WriteLine(item);

//Seventh Task.

string[] str1 = new[] { "Hello", "World", "Alif", "Academy", "Car" };

IEnumerable<char> res = str1.Select(s => s[0]);

List<char> resList = str1.Select(s => s[0]).ToList();

foreach (char item in resList)
    Console.WriteLine("The first character of array: " + item);

// Eight Task.

int[] ints = new[] { 1, 2, 3, 4, 5, 6, 7 };

string[] oddNumberStrings = ints
    .Where(n => n % 2 != 0)
    .Select(n => n.ToString())
    .ToArray();

foreach(string item in oddNumberStrings)
    Console.WriteLine("Odd numbers string element: " + item);

