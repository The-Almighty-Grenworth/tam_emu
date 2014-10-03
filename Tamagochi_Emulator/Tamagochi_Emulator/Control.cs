using System;
using System.Threading;

class Control {
    public static bool Doomsday;

    static void Main() { 
        //call your methods here
        InputHandler ih = new InputHandler();


        Thread t1 = new Thread(new ThreadStart(ih.beginParse));
        Thread t2 = new Thread(new ThreadStart(ih.listenForInput));


        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        Console.WriteLine("Teminating application...");
    
    }
}