System Car
{
    ![alt](images/map3.png) 


//horizontal road
    Move(int i = 0; i < 11); //N.1
    Turn(); //Up
    Peek();

        Move(int i = 0; i < 2); //N.1
        Turn(); //right
        Peek();

    Move(int i = 0; i < 10); //N.2
    Turn(int i = 0; i < 3); //down,left,up
    Peek();

        Move(int i = 0; i < 2); //N.2
        Turn(int i = 0; i < 3); //right,down,left
        Peek();

    Move(int i = 0; i < 10); //N.3
    Turn(); //up
    Peek();

        Move(int i = 0; i < 2); //N.3
        Turn(); //right
        Peek();

    Move(int i = 0; i < 10); //N.4

//vercial Road
    Turn(int i = 0; i < 3); //down,left,up
    Peek();

        Move(int i = 0; i < 7); //N.5
        Turn(int i = 0; i < 3); //right,down,left
        Peek();

    Move(int i = 0; i < 2); //N.5
    Turn(int i = 0; i < 3); //up,right,down
    Peek();

        Move(int i = 0; i < 5); //N.6
        Turn(); //left
        Peek();

    Move(int i = 0; i < 2); //N.6
    Turn(); //up
    Peek();

        Move(int i = 0; i < 5); //N.7
        Turn(int i = 0; i < 3); //right,down,left
        Peek();

    Move(int i = 0; i < 2); //N.7
    Turn(int i = 0; i < 3); //up,right,down
    Peek();

        Move(int i = 0; i < 5); //N.8
        Turn(); //left
        Peek();
    
    Move(int i = 0; i < 2) //N.8
    Turn(); //up
    Peek();

        Move(int i = 0; i < 5); //N.8
        Turn(int i = 0; i < 3); //right,down,left
        Peek();
    
    Move(int i = 0; i < 3); 
    AtGaol();
}