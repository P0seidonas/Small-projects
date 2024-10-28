using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_RPG
{
    public class MainText
    {
        public void GameName()
        {
            Console.ForegroundColor = ConsoleColor.Green; //Text color

            //Console.BackgroundColor = ConsoleColor.Red; //Highlight the text background

            //Console.ResetColor(); //Reset color changes to default

            //Console.WriteLine("⚅");
            Console.WriteLine("\r\n\r\n ______   __     ______     __  __        __         ______     __   __     _____    \r\n/\\  ___\\ /\\ \\   /\\  ___\\   /\\ \\_\\ \\      /\\ \\       /\\  __ \\   /\\ \"-.\\ \\   /\\  __-.  \r\n\\ \\  __\\ \\ \\ \\  \\ \\___  \\  \\ \\  __ \\     \\ \\ \\____  \\ \\  __ \\  \\ \\ \\-.  \\  \\ \\ \\/\\ \\ \r\n \\ \\_\\    \\ \\_\\  \\/\\_____\\  \\ \\_\\ \\_\\     \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_\\\\\"\\_\\  \\ \\____- \r\n  \\/_/     \\/_/   \\/_____/   \\/_/\\/_/      \\/_____/   \\/_/\\/_/   \\/_/ \\/_/   \\/____/ \r\n                                                                                     \r\n\r\n");
            
            //Console.WriteLine("\r\n\r\n ,---.,-.   .---. .-. .-. ,-.      .--.  .-. .-. ,'|\"\\   \r\n | .-'|(|  ( .-._)| | | | | |     / /\\ \\ |  \\| | | |\\ \\  \r\n | `-.(_) (_) \\   | `-' | | |    / /__\\ \\|   | | | | \\ \\ \r\n | .-'| | _  \\ \\  | .-. | | |    |  __  || |\\  | | |  \\ \\\r\n | |  | |( `-'  ) | | |)| | `--. | |  |)|| | |)| /(|`-' /\r\n )\\|  `-' `----'  /(  (_) |( __.'|_|  (_)/(  (_)(__)`--' \r\n(__)             (__)     (_)           (__)             \r\n\r\n");
        }

        public string[] GetMenuText()
        {
            return new string[] { "GO FISHING", "UPGRADES", "INVENTORY", "DELETE SAVE FILE" };
        }

        public string[] GetFishingPond()
        {
            return new string[] { "POND", "LAKE", "RIVER", "SEA", "OCEAN" };
        }


        public string GetBottomImages()
        {
            List<string> textImages = new List<string>();

            textImages.Add("       .\r\n      \":\"\r\n    ___:____     |\"\\/\"|\r\n  ,'        `.    \\  /\r\n  |  O        \\___/  |\r\n~^~^~^~^~^~^~^~^~^~^~^~^~");
            textImages.Add("|\\    \\ \\ \\ \\ \\ \\ \\      __   \r\n|  \\    \\ \\ \\ \\ \\ \\ \\   | O~-_\r\n|   >----|-|-|-|-|-|-|--|  __/\r\n|  /    / / / / / / /   |__\\  \r\n|/     / / / / / / /");
            textImages.Add("     /\"*._         _\r\n      .-*'`    `*-.._.-'/\r\n    < * ))     ,       ( \r\n      `*-._`._(__.--*\"`.\\");
            textImages.Add(" o\r\no      ______/~/~/~/__           /((\r\n  o  // __            ====__    /_((\r\n o  //  @))       ))))      ===/__((\r\n    ))           )))))))        __((\r\n    \\\\     \\)     ))))    __===\\ _((\r\n     \\\\_______________====      \\_((\r\n                                 \\((");

            Random rnd = new Random();
            int sizeList = textImages.Count;
            int randomImage = rnd.Next(0, sizeList);

            return textImages[randomImage];
        }
    }
}
