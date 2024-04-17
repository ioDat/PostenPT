using System.Dynamic;
using System.Globalization;

namespace PostenGPT.Post;

public class Packing
{
    private Package package;

    private List<int> dimensions;
    
    public int Weight { get; set; }

    public double Price { get; set; } = 0;
    public String PackingDescription { get; set; } = "";

    public List<int> Dimensions
    {
        get => dimensions;
        set => dimensions = value;
    }

    public Packing(Package package)
    {
        this.package = package;
        this.Weight = package.Weight;
        
        Expand();
    }

    public override string ToString()
    {
        return PackingDescription /* + " - " + Weight*/ + "g (Price: "+ Price.ToString("C",CultureInfo.CreateSpecificCulture("no-NB")) + ")";
    }

    private void Expand()
    {            
            // refactor by placing package options into a colection and select best from list
            // mod
            
            // Padded envelope
            if (package.Dimensions[0] <= 160 && package.Dimensions[1] <= 110 && package.Dimensions[2] < 20)
            {
                // 11x16 cm
                PackingDescription = "11x16 cm boblekonvolutt";
                Price = 2.99;
                Dimensions = new List<int>(){160,110, package.Dimensions[2]};

            }
            else if (package.Dimensions[0] <= 210 && package.Dimensions[1] <= 150 && package.Dimensions[2] < 20)
            { 
                // 15x21 cm      
                PackingDescription = "15x21 cm cm boblekonvolutt";
                Price = 2.99;
                Dimensions = new List<int>(){210,150, package.Dimensions[2]};
            }            
            else if (package.Dimensions[0] <= 260 && package.Dimensions[1] <= 180 && package.Dimensions[2] < 20)
            { 
                // 18x26 cm            
                PackingDescription = "18x26 cm boblekonvolutt";
                Price = 5.90;
                Dimensions = new List<int>(){260,180, package.Dimensions[2]};
            }            
            else if (package.Dimensions[0] <= 360 && package.Dimensions[1] <= 270 && package.Dimensions[2] < 20)
            { 
                // 27x36 cm                
                PackingDescription = "27x36 cm boblekonvolutt";
                Price = 8.50;
                Dimensions = new List<int>(){360,270, package.Dimensions[2]};
            }            
            else if (package.Dimensions[0] <= 470 && package.Dimensions[1] <= 350 && package.Dimensions[2] < 20)
            {
                // 35x47 cm       
                PackingDescription = "35x47 cm boblekonvolutt";
                Price = 15.00;
                Dimensions = new List<int>(){470,350, package.Dimensions[2]};
            }
            
            // Checkin parcels
            else if (package.Dimensions[0] <= 240 && package.Dimensions[1] <= 159 && package.Dimensions[2] <= 60)
            {
                // mini pakke
                PackingDescription = "Mini pakke";
                Price = 18.0;
                Weight += 67;
                Dimensions = new List<int>(){240,159, 60};
                
            }
            
            else if (package.Dimensions[0] <= 332 && package.Dimensions[1] <= 246 && package.Dimensions[2] <= 65)
            {
                // Liten pakke
                PackingDescription = "Liten pakke";
                Price = 20.0;
                Weight += 126; // 125.5g
                Dimensions = new List<int>(){322,246, 63};
            }       
            
            else if (package.Dimensions[0] <= 350 && package.Dimensions[1] <= 250 && package.Dimensions[2] <= 120)
            {
                // Norgespakke
                PackingDescription = "Norgespakke";
                Price = 24.0;
                Weight += 191;
                Dimensions = new List<int>(){350, 250, 120};
            }
            
            else if (package.Dimensions[0] <= 500 && package.Dimensions[1] <= 300 && package.Dimensions[2] <= 200)
            {
                // Stor pakke
                PackingDescription = "Stor pakke";
                Price = 27.0;
                Weight += 359;
                Dimensions = new List<int>(){500, 150, 200};
            }
            else
            {
                PackingDescription = "No suitable packing option";
                Dimensions = package.Dimensions;
            }
            
        }
    }
