//All() can take an IEnummerable and a Func that returns a bool.
//All() iterates on the collection and checks if the Func returns true for all of the members.
//All() may not iterate on the whole collection and returns False with
//  the first member that the Func returns False for.

var pets = new[]
{
    new Pet(1, "Hannibal", PetType.Fish, 1.1f),
    new Pet(2, "Storm", PetType.Cat, 0.9f),
    new Pet(3, "boss", PetType.Dog, 0.9f),
    new Pet(4, "harry", PetType.Fish, 0.9f)
};

var doAllHaveNonEmptyNames = pets.All(pet => !string.IsNullOrEmpty(pet.Name));

Console.WriteLine("doAllHaveNonEmptyNames:" + doAllHaveNonEmptyNames);

var areAllCats = pets.All(pet => pet.Type == PetType.Cat);

Console.WriteLine("areAllCats:" + areAllCats);