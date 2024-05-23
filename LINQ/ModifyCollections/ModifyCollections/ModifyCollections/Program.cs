//Because LINQ works with IEnumerable and IEnumerable doesn't have
//modification methods, LINQ methods won't effect the original collection

var numbers  = new List<int> { 1, 2, 3, 4, 5 };
var nuumbersWithSix = numbers.Append(6);

Console.WriteLine("numbers: " + string.Join(", ",numbers));
Console.WriteLine("numbersWitSix: " + string.Join(", ", nuumbersWithSix));