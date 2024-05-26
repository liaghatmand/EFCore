//Any takes an IEnummerable and a Func that returns a bool.
//Any iterates on the collection and checks if the Func returns true for any member.
//Any may not iterate on the whole collection and returns true with
//  the first member that the Func returns true for.

public enum PetType
{
    Fish = 0,
    Dog = 1,
    Cat = 2
}