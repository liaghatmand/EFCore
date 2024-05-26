//All() can take an IEnummerable and a Func that returns a bool.
//All() iterates on the collection and checks if the Func returns true for all of the members.
//All() may not iterate on the whole collection and returns False with
//  the first member that the Func returns False for.
public class Pet(int id, string name, PetType type, float weight)
{
    public int Id = id;
    public string Name = name;
    public PetType Type = type;
    public float Weight = weight;
}