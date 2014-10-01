using System;
using System.Threading;

class Control {
    static void Main() { 
        //call your methods here
        InputHandler ih = new InputHandler();


        Thread t1 = new Thread(ih.beginParse());
        Thread t2 = new Thread(ih.listenForInput());


        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        Console.WriteLine("Teminating application...");
    
    }
}