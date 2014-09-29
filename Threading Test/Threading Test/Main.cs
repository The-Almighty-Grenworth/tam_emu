using System;
using System.Threading;

class Mayan
{

    static string input = "null";

    private string temp;

    public void getInput()
    {
        while (true)
        {
            input = Console.ReadLine();
        }
    }

    public int handleInput()
    {
        while (true)
        {
            if (input != "null")
            {
                temp = input;
                input = "null";
                if (temp == "exit")
                {
                    return 1;
                }
                else if (temp == "hi?")
                {
                    Console.WriteLine("helloworld!");
                }
                else if (temp == "loopme") {
                    for (int x = 0; x != 99; x++) {
                        Console.Write("x");
                    }
                }
                
            }
        }
    }
}

class run
{
    static void Main()
    {
        Mayan test = new Mayan();

        // this is running in a new thread called tt.
        Thread tt = new Thread(test.getInput);
        tt.Start();

        // below is running in the main thread.
        if (test.handleInput() == 1)
        {
            tt.Abort(); //if i don't abort the other thread it will keep running and console won't close even though I ran return
            return;

        }

    }
}