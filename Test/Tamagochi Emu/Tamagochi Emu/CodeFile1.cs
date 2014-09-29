using System;
using System.Threading;

class Mayan {

    static string input = "null";

    

    public void getInput() {
        while (true) {
            input = Console.ReadLine();
        }
    }

    public int handleInput() {
        while (true) {
            if (input != "null") {
                
                if (input == "exit") {
                    return 1;
                }
                else if (input == "hi?") {
                    Console.WriteLine("helloworld!");
                }
                input = "null";
            }
        }
    }
}

class run {
    static void Main()
    {
        Mayan test = new Mayan();

        Thread tt = new Thread(test.getInput);
        tt.Start();

        if (test.handleInput() == 1)
        {
            tt.Abort();
            return;
            
        }

    }
}