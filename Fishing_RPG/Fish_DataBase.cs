using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_RPG
{
    internal class Fish_DataBase
    {
        public string FishSpecies { get; set; }
        public float FishMaxWeight { get; set; }
        public float FishPricePerKg { get; set; }
        public string FishRarity { get; set; }

        public Fish_DataBase(string species, float weight, float price, string rarity)
        {
            FishSpecies = species;
            FishMaxWeight = weight;
            FishPricePerKg = price;
            FishRarity = rarity;  //Kur parduotuve??
        }
    }
}