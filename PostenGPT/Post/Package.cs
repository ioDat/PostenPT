using System.Collections.Immutable;

namespace PostenGPT.Post;

public class Package
{
    public string description;
    private List<int> dimensions;

    public Package(string description, List<int> dimensions)
    {
        this.description = description;
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
        return description + " " + dimensions[0] + " " + dimensions[1] + " " + dimensions[2];
    }
}