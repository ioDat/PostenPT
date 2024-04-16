namespace PostenGPT.Post;

public class PackageCollection
{
    public string info { get; set; }

    public IEnumerable<Package> packages{ get; set; }
}
