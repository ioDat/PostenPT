using System.Collections.Immutable;

namespace PostenGPT.Post;

public class Package
{
    public string Description { get; set; }
    public int Weight { get; set; }
    private List<int> dimensions;

    public Package(string description, List<int> dimensions)
    {
        this.Description = description;
        this.Dimensions = dimensions;
    }

    public List<int> Dimensions
    {
        get => dimensions;
        set
        {
            // Sort values after we create a package
            dimensions = value;
            dimensions.Sort();
            dimensions.Reverse();
        }
    }

    public override string ToString()
    {
        return Description + "\n" + dimensions[0] + "mm x " + dimensions[1] + "mm x " + dimensions[2] + "mm - " + Weight + "g";
    }
}