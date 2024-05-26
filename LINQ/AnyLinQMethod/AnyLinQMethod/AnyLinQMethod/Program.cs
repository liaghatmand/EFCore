//Any() can take an IEnummerable and a Func that returns a bool.
//Any() iterates on the collection and checks if the Func returns true for any member.
//Any() may not iterate on the whole collection and returns true with
//  the first member that the Func returns true for.
//Any() can take no parameters to simply check if the collection is not empty.

//Ex1
var numbers = new[] { 5, 9, 2, 12, 6 };

bool isAnyLargerThan10  = numbers.Any(number => number > 10);

Console.WriteLine(isAnyLargerThan10);

//Ex2


var pets = new[]
{
    new Pet(1, "Hannibal", PetType.Fish, 1.1f),
    new Pet(2, "Storm", PetType.Cat, 0.9f),
    new Pet(3, "boss", PetType.Dog, 0.9f),
    new Pet(4, "harry", PetType.Fish, 0.9f)

};

var isAnyPetWithThisCriterias = pets.Any(pet => pet.Name.Length > 6 && pet.Id < 2);

