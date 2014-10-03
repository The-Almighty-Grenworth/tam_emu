using System;

class InputHandler {
    private static string input = "null";
    private string temp;

    public void beginParse() {
        while (true) {
            temp = input;
            input = "null";

            switch (temp) { 
                case "exit":
                    Console.WriteLine("terminating application...");
                    Control.Doomsday = true;
                    break;

            }
        }
    }

    public void listenForInput() { 
        while (true) {
            input = Console.ReadLine();
        }
    }

    public void resetInput() {
        input = "null";
    }
}