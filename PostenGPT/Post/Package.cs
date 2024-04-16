using System.Collections.Immutable;

namespace PostenGPT.Post;

public class Package
{
    private string name;
    private List<int> dimensions;

    public Package(string name, List<int> dimensions)
    {
        this.name = name;
        this.dimensions = dimensions;
    }

    public List<int> Dimensions
    {
        get => dimensions;
        set
        {
            // Sort values after we create a package
            dimensions = value;
            dimensions.Sort();
        }
    }

    public override string ToString()
    {
        return name + dimensions[0] + " " + dimensions[1] + " " + dimensions[2];
    }
}