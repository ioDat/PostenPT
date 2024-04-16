using System.Dynamic;

namespace PostenGPT.Post;

public class Packing
{
    private Package p;

    private List<int> dimensions;
    
    public int Weight { get; set; }

    public double Price { get; set; } = 0;
    public String PackingDescription { get; set; } = "";

    public List<int> Dimensions
    {
        get => dimensions;
        set => dimensions = value;
    }

    public Packing(Package p)
    {
        this.p = p;
        this.Weight = p.Weight;
        
        Expand();
    }

    public override string ToString()
    {
        return PackingDescription + " - " + Weight + "g";
    }


    private void Expand()
    {            
            // refactor by placing package options into a colection and select best from list
            // mod
            
            // Padded envelope
            if (p.Dimensions[0] <= 160 && p.Dimensions[1] <= 110 && p.Dimensions[2] < 20)
            {
                // 11x16 cm
                PackingDescription = "11x16 cm boblekonvolutt";
                Price = 2.99;
                Dimensions = new List<int>(){160,110, p.Dimensions[2]};

            }
            else if (p.Dimensions[0] <= 210 && p.Dimensions[1] <= 150 && p.Dimensions[2] < 20)
            { 
                // 15x21 cm      
                PackingDescription = "15x21 cm cm boblekonvolutt";
                Price = 2.99;
                Dimensions = new List<int>(){210,150, p.Dimensions[2]};
            }            
            else if (p.Dimensions[0] <= 260 && p.Dimensions[1] <= 180 && p.Dimensions[2] < 20)
            { 
                // 18x26 cm            
                PackingDescription = "18x26 cm boblekonvolutt";
                Price = 5.90;
                Dimensions = new List<int>(){260,180, p.Dimensions[2]};
            }            
            else if (p.Dimensions[0] <= 360 && p.Dimensions[1] <= 270 && p.Dimensions[2] < 20)
            { 
                // 27x36 cm                
                PackingDescription = "27x36 cm boblekonvolutt";
                Price = 8.50;
                Dimensions = new List<int>(){360,270, p.Dimensions[2]};
            }            
            else if (p.Dimensions[0] <= 470 && p.Dimensions[1] <= 350 && p.Dimensions[2] < 20)
            {
                // 35x47 cm       
                PackingDescription = "35x47 cm boblekonvolutt";
                Price = 15.00;
                Dimensions = new List<int>(){470,350, p.Dimensions[2]};
            }
            
            // Checkin parcels
            else if (p.Dimensions[0] <= 240 && p.Dimensions[1] <= 159 && p.Dimensions[2] <= 60)
            {
                // mini pakke
                PackingDescription = "Mini pakke";
                Price = 18.0;
                Weight += 67;
                Dimensions = new List<int>(){240,159, 60};
                
            }
            
            else if (p.Dimensions[0] <= 332 && p.Dimensions[1] <= 246 && p.Dimensions[2] <= 65)
            {
                // Liten pakke
                PackingDescription = "Liten pakke";
                Price = 20.0;
                Weight += 126; // 125.5g
                Dimensions = new List<int>(){322,246, 63};
            }       
            
            else if (p.Dimensions[0] <= 350 && p.Dimensions[1] <= 250 && p.Dimensions[2] <= 120)
            {
                // Norgespakke
                PackingDescription = "Norgespakke";
                Price = 24.0;
                Weight += 191;
                Dimensions = new List<int>(){350, 250, 120};
            }
            
            else if (p.Dimensions[0] <= 500 && p.Dimensions[1] <= 300 && p.Dimensions[2] <= 200)
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
                Dimensions = p.Dimensions;
            }
            
        }
    }
