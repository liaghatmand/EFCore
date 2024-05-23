//Deffered execution means the evaluation of a LINQ expression is delayed
//until the value is actually needed.
//this is to improve performance.

var words = new List<string> { "a", "bb", "ccc", "dddd" };

//The query is only created here, this is just a query not data.
var shortwords = words.Where(word => word.Length < 3).ToList();

//The execution (materialization) happens in the foreach loop.
Console.WriteLine("First Iteration:\n");

foreach (var word in shortwords)
{
    Console.WriteLine(word);
}

words.Add("e");

//Seems like we printed the same set of data: shortcodes.
//But the result is different and both "Where" and "Add" are executed in the last loop.

//If we want shortwords to stay the same
//we have to materialize it with ".ToList()" at the end of "Where".

Console.WriteLine("\nSecond Iteration:\n");
foreach (var word in shortwords)
{
    Console.WriteLine(word);
}

