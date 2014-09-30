using System;

class Tamagochi { 
    //static variables
    private static int tamcount = 0;

    //Main variables

    //Constructor
    public void Tamagochi() {
        tamcount++;

    }

    //Methods
    public int CreatedObjectsCount() {
        return tamcount;
    }
}