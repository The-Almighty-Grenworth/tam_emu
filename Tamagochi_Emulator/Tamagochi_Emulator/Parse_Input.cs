using System;

class InputHandler {
    private static string input = "null";
    private string temp;

    public int beginParse() {
        while (true) {
            temp = input;
            input = "null";

            switch (temp) { 
                case "exit":
                    Console.WriteLine("terminating application...");
                    return 1;

            }
        }
    }

    public void listenForInput() { 
        while (true) {
            input = Console.ReadLine();
        }
    }

    public string getInput() {
        return input;
    }
    public void resetInput() {
        input = "null";
    }
}