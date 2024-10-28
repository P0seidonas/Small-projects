using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_RPG
{
    
    class Inventory
    {
        const string FishDataInfo = "FishData.txt";

        public static void ReadData(Fish_DataBase fish)
        {
            string line = String.Format("{0};{1};{2};{3};{4}",
                fish.FishSpecies, fish.FishMaxWeight, fish.FishPricePerKg, fish.FishRarity, "\n");
            Console.WriteLine("LETS FUKIN GOOOOOOO!!!!!!!!");
            File.AppendAllText(FishDataInfo, line, Encoding.UTF8);
        }

        public static void DeleteAllData()
        {
            File.Delete(FishDataInfo);
        }
    }
    
}
