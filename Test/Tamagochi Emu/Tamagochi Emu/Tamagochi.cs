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
    static int Main()
    {
        string command;
        Random rnd = new Random();

        Console.WriteLine("What is the Tamagochi Called?");
        Tamagochi tamagochi = new Tamagochi(Console.ReadLine(),rnd.Next(5,10));
        tamagochi.PrintDeets();

        Console.WriteLine("What is the Tamagochi Called?");
        Tamagochi tamagochi1 = new Tamagochi(Console.ReadLine(), rnd.Next(5, 10));
        tamagochi1.PrintDeets();
        Console.WriteLine("What is the Tamagochi Called?");
        Tamagochi tamagochi2 = new Tamagochi(Console.ReadLine(), rnd.Next(5, 10));
        tamagochi2.PrintDeets();

        while (true)
        {
            Console.Write("Command:> ");
            command = Console.ReadLine();
            if (command == "tam -num")
            {
                Tamagochi.HowMany();
            }
            else if (command == "exit") {
                Console.WriteLine("Exiting...");
                return 1;
            }
            else
            {
                Console.WriteLine("Invalid Command!");
                return 1;
            }
        }
        
    }
}
