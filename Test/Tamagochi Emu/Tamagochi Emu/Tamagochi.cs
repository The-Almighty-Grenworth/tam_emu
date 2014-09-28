using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Tamagochi_Emu
//{
    class Tamagochi
    {
        private static int yolo = 0;

        private String name;
        private int Health;
        private int Hunger;
        private int Happiness;
        private Double Lifespan;
        private int Love;
        private int Level;
        private int shitlevel;

        public static void HowMany() {
            Console.WriteLine(yolo + " Tamagochi's have been made");
        }

        public Tamagochi(string name,int Lifespan)
        {
            this.name = name;
            Health = 100;
            Hunger = 100;
            Happiness = 100;
            this.Lifespan = Lifespan;
            yolo++;
            
        }
        public void PrintDeets()
        {
            Console.WriteLine("My name is "+name);
            Console.WriteLine("My Life expectancy is " + Lifespan);
        }
    }
//}
class main
{
    static void Main()
    {

        Random rnd = new Random();
        Tamagochi tamagochi = new Tamagochi("Leleknamepls",rnd.Next(5,10));
        tamagochi.PrintDeets();
        Tamagochi lelki = new Tamagochi("Leleknamepls", rnd.Next(5, 10));
        Tamagochi tam998 = new Tamagochi("Leleknamepls", rnd.Next(5, 10));
        Console.ReadKey();
        Tamagochi.HowMany();
        Console.ReadKey();
        
    }
}
