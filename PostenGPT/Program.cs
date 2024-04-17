using System.Text;
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

StringBuilder shoppingList = new StringBuilder();
shoppingList.Append("Shopping List \n\n");

//Console.WriteLine("Loaded packages");
foreach (Package p in pc.packages)
{
    //Console.WriteLine(p.ToString());
    shoppingList.Append("ITEM:" + p.);
    shoppingList.Append("\n");
    
    
    // Spec 2: Find the best packing option
    Packing pack = new Packing(p);
    shoppingList.Append("Packing Option:" + pack);
    shoppingList.Append("\n");
    
    
    // Spec 3: Find the best postage option
    Postage post = new Postage(pack);
    // Console.WriteLine(post);
    shoppingList.Append("Postage Option:" + post);
    shoppingList.Append("\n");
    
    
    // Console.WriteLine(pack + "\n");
    shoppingList.AppendLine();
}




// Spec 4: Output shopping list => file
StreamWriter sw = new StreamWriter("shoppinglist.txt");
sw.WriteLine(shoppingList.ToString());
sw.Close();


// Spec 5: Readme and other docs



