System Car
{
    ![alt](images/map5.png) 
    
    Peek();
    Move(int i = 0; i < 3);
    Turn(); //up
    Peek();

    Move(int i = 0; i < 7);
    Turn(int i = 0; i < 3); //right,down,left
    Peek();
    
    Move(int i = 0; i < 2);
    Turn(int i = 0; i < 3); //up,right,down
    Peek();

    Move(int i = 0; i < 3);
    Turn(); //left
    Peek();

    Move(int i = 0; i < 4);
    Turn(int i = 0; i < 3); //up,right,down
    Peek();

    Move(int i = 0; i < 2);
    Turn(int i = 0; i < 3); //left,up,right
    Peek();

    Move(int i = 0; i < 4);
    Turn(); //down
    Peek();

    
    Move(int i = 0; i < 2);
    Turn(); //left
    Peek();

    Move(int i = 0; i < 7);
    Turn(int i = 0; i < 3); 
    Peek();

    Move(int i = 0; i < 2);
    AtGoal();
}