//Any takes an IEnummerable and a Func that returns a bool.
//Any iterates on the collection and checks if the Func returns true for any member.
//Any may not iterate on the whole collection and returns true with
//  the first member that the Func returns true for.

internal class Pet(int id, string name, PetType type, float weight)
{
    public int Id = id;
    public string? Name = name;
    public PetType Type = type;
    public float Weight = weight;
}