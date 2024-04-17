using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PostenGPT.Post;
public class Postage
{
    public Packing packing;
    public string Description { get; set; } = "";
    public double PostageCost { get; set; } = 0;

    public Postage(Packing packing)
    {
        this.packing = packing;

        CalculatePostage();
    }


    public override string ToString()
    {
        return Description + " (Price: " + PostageCost.ToString("C",CultureInfo.CreateSpecificCulture("no-NB")) + ")";
    }
    
    
    /// <summary>
    /// Finds the 'best' postage option based on the weight and dimension of the packed item.
    /// </summary>
    private void CalculatePostage()
    {
        if (packing.Weight <= 350 &&
            packing.Dimensions[0] <= 350 &&
            packing.Dimensions[1] <= 250 &&
            packing.Dimensions[2] <= 70)
        {
            Description = "Brev under 350g";
            if (packing.Weight <= 20)
            {
                Description += " - <=20g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 23.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk ";
                }
            }
            else if (packing.Weight <= 50)
            {
                Description += " - <=50g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 29.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk";
                }
            }
            else if (packing.Weight <= 100)
            {
                Description += " - <=100g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 36.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk";
                }
            }
            else
            {
                Description += " - <=350g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 55.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk";
                }
            }
        }
        else if (packing.Dimensions[0] <= 350 &&
                 packing.Dimensions[1] <= 250 &&
                 packing.Dimensions[2] <= 120 &&
                 packing.Weight >= 350 &&
                 packing.Weight <= 5000)
        {
            // Norgespakke liten
            PostageCost = 73.00;
            Description = "Norgespakke liten";
        }
        else if (packing.Weight <= 2000 &&
                 (packing.Dimensions[0] +
                     packing.Dimensions[1] +
                     packing.Dimensions[2] <= 900) &&
                 packing.Dimensions[0] <= 600)
        {
            Description = "Brev fra 350g til 2kg";
            if (packing.Weight <= 20)
            {
                Description += " - <=20g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 23.00;
                    Description += " - Inntil 2 cm tykk (<20g)";
                }
                else if (packing.Dimensions[2] <= 70)
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk";
                }
                else
                {
                    PostageCost = 90.00;
                    Description += " - Mer enn 7 cm tykk";
                }
            }
            else if (packing.Weight <= 50)
            {
                Description += " - <=50g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 29.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else if (packing.Dimensions[2] <= 70)
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk";
                }
                else
                {
                    PostageCost = 90.00;
                    Description += " - Mer enn 7 cm tykk";
                }
            }
            else if (packing.Weight <= 100)
            {
                Description += " - <=100g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 36.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else if (packing.Dimensions[2] <= 70)
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk";
                }
                else
                {
                    PostageCost = 90.00;
                    Description += " - Mer enn 7 cm tykk";
                }
            }
            else if (packing.Weight <= 350)
            {
                Description += " - <=350g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 55.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else if (packing.Dimensions[2] <= 70)
                {
                    PostageCost = 57.00;
                    Description += " - 2–7 cm tykk";
                }
                else
                {
                    PostageCost = 90.00;
                    Description += " - Mer enn 7 cm tykk";
                }
            }
            else if (packing.Weight <= 1000)
            {
                Description += " - <=1000g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 90.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else if (packing.Dimensions[2] <= 70)
                {
                    PostageCost = 105.00;
                    Description += " - 2–7 cm tykk";
                }
                else
                {
                    PostageCost = 140.00;
                    Description += " - Mer enn 7 cm tykk";
                }
            }
            else if (packing.Weight <= 2000)
            {
                Description += " - <=2000g";
                if (packing.Dimensions[2] <= 20)
                {
                    PostageCost = 125.00;
                    Description += " - Inntil 2 cm tykk";
                }
                else if (packing.Dimensions[2] <= 70)
                {
                    PostageCost = 135.00;
                    Description += " - 2–7 cm tykk";
                }
                else
                {
                    PostageCost = 175.00;
                    Description += " - Mer enn 7 cm tykk";
                }
            }
        }
        else if ((packing.Dimensions[0] <= 1200 &&
                 packing.Dimensions[1] <= 600 &&
                 packing.Dimensions[2] <= 600) ||
                 packing.Weight >= 2000)
        {
            // Norgespakke stor
            Description = "Norgespakke stor";
            if (packing.Weight <= 10000)
            {
                PostageCost = 135.00;
            }
            else if (packing.Weight <= 25000)
            {
                PostageCost = 240.00;
            }
            else if (packing.Weight <= 35000)
            {
                PostageCost = 314.00;
            }
        }
        else
        {
            Description = "too large to ship";
        }
    }
}