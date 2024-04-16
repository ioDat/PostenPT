using System.Text.Json.Serialization;
using Newtonsoft.Json;
using PostenGPT;
using PostenGPT.Post;

/*
Package p = new Package("thing", new List<int>(){10,15,5});

Console.WriteLine(p.ToString());
*/


// Spec 1: Read a json file and convert to a collection of packages
String file = "items.json";

PackageCollection pc = new PackageCollection();

try
{
    StreamReader sr = new StreamReader(file);
    pc = JsonConvert.DeserializeObject<PackageCollection>(sr.ReadToEnd());
}
catch (FileNotFoundException e)
{
    Console.WriteLine("File not found.");
}
catch (Exception e)
{
    Console.WriteLine(e);
}


Console.WriteLine("Loaded packages");
foreach (Package p in pc.packages)
{
    Console.WriteLine(p.ToString());
}

// Spec 2: Find the best packing option


// Spec 3: Find the best postage option


// Spec 4: Output shopping list => file


// Spec 5: Readme and other docs

