//An extension method is a method designed outside of a type,
//that can be called upon this type's objects
//as a regular member method.
//They alow us to add new behavior to a type without changing it.
//It has to be static
using System.Reflection.Metadata.Ecma335;

var multiLineString = @"
I am Zahra and I have four years of 
programming experience.
I am a ,Net Programmer.
";

var countOfLines = multiLineString.CountOfLines();
Console.WriteLine(countOfLines);

public static class StringExtensions
{
    public static int CountOfLines(this string str) 
        => str.Split("\n").Length;
}