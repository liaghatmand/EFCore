//All() can take an IEnummerable and a Func that returns a bool.
//All() iterates on the collection and checks if the Func returns true for all of the members.
//All() may not iterate on the whole collection and returns False with
//  the first member that the Func returns False for.

public enum PetType
{
    Fish = 0,
    Dog = 1,
    Cat = 2
}