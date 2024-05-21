//Is Any number in an array > 100?
//Is Any even numbers in an array?
//Does any string in a list start with a letter "P"?

var numbers = new[] { 1, 4, 3, 99, 0, 2 };
var words = new[] { "Persepolise", "Iran", "Kourosh" };

//without lambda expressions : there is some code duplications

bool isAnyLargerThan100 = IsAnyLargerThan100(numbers);
bool isAnyEvenNumbers = IsAnyEvenNumbers(numbers);
bool doesAnyBeginWithP = DoesAnyBeginWithP(words);


Console.WriteLine($"Is there any larger than 100: {isAnyLargerThan100}");
Console.WriteLine($"Is there any even numbers?: {isAnyEvenNumbers}");
Console.WriteLine($" Does any word begin with P?: {doesAnyBeginWithP}");
Console.ReadKey();

static bool IsAnyLargerThan100(int[] numbers)
{
    foreach (int number in numbers)
    {
        if (number > 100) return true;
    }
    return false;
}

static bool IsAnyEvenNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        if (number % 2 == 0) return true;
    }
    return false;
}

bool DoesAnyBeginWithP(string[] words)
{
    foreach (string word in words)
    {
        foreach (char letter in word)
        {
            if (letter == 'P')
            {
                return true;
            }
        }
    }
    return false;
}

//with Func<,>

bool isAnyLargerThan100_Func = IsIntAny(numbers, IsAnyLargerThan100_Func);
bool isAnyEvenNumbers_Func = IsIntAny(numbers, IsAnyEvenNumbers_Func);
bool doesAnyBeginWithP_Func = IsStringAny(words, DoesAnyBeginWithP_Func);


Console.WriteLine($"Is there any larger than 100: {isAnyLargerThan100_Func}");
Console.WriteLine($"Is there any even numbers?: {isAnyEvenNumbers_Func}");
Console.WriteLine($"Does any word begin with P?: {doesAnyBeginWithP_Func}");
Console.ReadKey();

static bool IsIntAny(int[] numbers, Func<int, bool> predicate)
{
    foreach (int number in numbers)
    {
        if (predicate(number)) return true;
    }
    return false;
}

static bool IsStringAny(string[] words, Func<string, bool> predicate)
{
    foreach (string word in words)
    {
        if (predicate(word)) return true;
    }
    return false;
}
static bool IsAnyLargerThan100_Func(int number)
{
    return number > 100;
}

static bool IsAnyEvenNumbers_Func(int number)
{
    return number % 2 == 0;

}

bool DoesAnyBeginWithP_Func(string word)
{
    foreach (char letter in word)
    {
        return (letter == 'P');
    }
    return false;
}

//With Lambda Expressions


bool isAnyLargerThan100_Lambda = IsIntAnyLambda(numbers, number => number > 100);
bool isAnyEvenNumbers_Lambda = IsIntAnyLambda(numbers, number => number % 2 == 0);
bool doesAnyBeginWithP_Lambda = IsStringAnyLambda(words, word =>
{
    foreach (char letter in word)
    {
        return (letter == 'P');
    }
    return false;
});


Console.WriteLine($"Is there any larger than 100: {isAnyLargerThan100_Lambda}");
Console.WriteLine($"Is there any even numbers?: {isAnyEvenNumbers_Lambda}");
Console.WriteLine($"Does any word begin with P?: {doesAnyBeginWithP_Lambda}");
Console.ReadKey();

static bool IsIntAnyLambda(int[] numbers, Func<int, bool> predicate)
{
    foreach (int number in numbers)
    {
        if (predicate(number)) return true;
    }
    return false;
}

static bool IsStringAnyLambda(string[] words, Func<string, bool> predicate)
{
    foreach (string word in words)
    {
        if (predicate(word)) return true;
    }
    return false;
}

//with Generic Lambda Expression


bool isAnyLargerThan100_Generic = IsAny(numbers, number => number > 100);
bool isAnyEvenNumbers_Generic = IsAny(numbers, number => number % 2 == 0);
bool doesAnyBeginWithP_Generic = IsAny(words, word => {
    foreach (char letter in word)
    {
        return (letter == 'P');
    }
    return false;
});


Console.WriteLine($"Is there any larger than 100?: {isAnyLargerThan100_Generic}");
Console.WriteLine($"Is there any even numbers?: {isAnyEvenNumbers_Generic}");
Console.WriteLine($"Does any word begin with P?: {doesAnyBeginWithP_Generic}");
Console.ReadKey();

static bool IsAny<T>(IEnumerable<T> items, Func<T, bool> predicate)
{
    foreach (var item in items)
    {
        if (predicate(item)) return true;
    }
    return false;
}