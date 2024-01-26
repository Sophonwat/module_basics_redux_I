System Car
{
    ![alt](images/map1.png)  //There are total of seven long road.
    
    Move(int i = 0; i < 37); //Road one
    Turn(); //up
    Peek(); //Next cell is open
        Move(int i = 0; i < 2); //Corner one
        Turn(); //Right
        Peek();

    Move(int i = 0; i < 36); //Road two
    Turn(); //Down
    Turn(); //Left 
    Turn(); //Up
    Peek();
        Move(int i = 0; i < 2); // Corner Two
        Turn(); //Right
        Turn(); //Down
        Turn(); //Left
        Peek();

    Move(int i = 0; i < 36); //Road three
    Turn(); //Up
    Peek();
        Move(int i = 0; i < 2); // Corner Three
        Turn(); //Right
        Peek();

    Move(int i = 0; i < 36); //Road Fourth
    Turn(); //Down
    Turn(); //Left 
    Turn(); //Up
    Peek();
        Move(int i = 0; i < 2); // Corner Fourth
        Turn(); //Right
        Turn(); //Down
        Turn(); //Left
        Peek();

    Move(int i = 0; i < 36); //Road Fifth
    Turn(); //Up
    Peek();
        Move(int i = 0; i < 2); // Corner Fifth
        Turn(); //Right
        Peek();

    Move(int i = 0; i < 36); //Road Sixth
    Turn(); //Down
    Turn(); //Left 
    Turn(); //Up
    Peek();
        Move(int i = 0; i < 2); // Corner Sixt
        Turn(); //Right
        Turn(); //Down
        Turn(); //Left
        Peek();

    Move(int i = 0; i < 37); //Road Seven
    AtGaol();
}