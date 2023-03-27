//TIC TAC TOE PROJECT FOR ZAB WIGGINS 9-22-22

string[,] board = new string[3, 3] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } }; //creating 2D string and initializing each element a value

drawBoard(board);//calling the drawBoard function to display the contents of the board array

do//run this while condition is true
{
    Console.WriteLine("Player 1, enter row number (top to bottom)");//prompt to user
    int x_coord = int.Parse(Console.ReadLine()) - 1;//declaring variable for first dimention array element #, subtracting 1 becasue arrays start with 0
    Console.WriteLine("Player 1, enter column number (left to right)");//prompt to user
    int y_coord = int.Parse(Console.ReadLine()) - 1; //declaring variable for second dimention array element #, subtracting 1 becasue arrays start with 0

    placeMarker(board, "X", x_coord, y_coord);//calling placemarker to write "X" to the element found at the coordinantes user assigned

    Console.Clear();//clearing console of old output
    drawBoard(board);//output, will show "x" where player has assigned it
    winCheck(board);//checking win conditions
    if (winCheck(board) == 1)//if wincheck returns 1 that means player 1 won
    {
        Console.WriteLine("Player 1 Wins!");//output
        break;//end program
    }
    else if (winCheck(board) == 3)//if win check returns 3, then all of the spaces are filled but no one has won
    {
        Console.WriteLine("TIE!");//output
        break;//end program
    }

    Console.WriteLine("Player 2, enter row number (top to bottom)");//prompt to user
    x_coord = int.Parse(Console.ReadLine()) - 1;//declaring variable for first dimention array element #, subtracting 1 becasue arrays start with 0
    Console.WriteLine("Player 2, enter column number (left to right)");//prompt for input
    y_coord = int.Parse(Console.ReadLine()) - 1;//declaring variable for second dimention array element #, subtracting 1 becasue arrays start with 0

    placeMarker(board, "O", x_coord, y_coord);//calling placemarker to write "X" to the element found at the coordinantes user assigned

    Console.Clear();//clearing console of old output
    drawBoard(board);//output - will show "O" where playre assigned it
    winCheck(board);//checking win conditions

    if (winCheck(board) == 2)//if wincheck returns 2, player 2 has won
    {
        Console.WriteLine("Player 2 wins!");//output
        break;//end program
    }
    else if (winCheck(board) == 3)//if wincheck returns 3 - all the spaces are filled but no one has won
    {
        Console.WriteLine("TIE!");//output
        break;//end program
    }

} while (winCheck(board) == 0);//checking condtion for while loop - wincheck 0 - no one won and no tie

static void drawBoard(string[,] board)//creating void function to accept a 2d array of strings
{
    Console.WriteLine("  1 2 3");//output
    Console.WriteLine("--------");//output
    for (int i = 0; i < board.GetLength(1); i++)//begin for loop, declaring and initializing counter var, setting max length to length of board, increment by 1;
    {
        Console.Write(i + 1 + "|");//output
        Console.Write("{0} ", board[i, 0]);//output
        Console.Write("{0} ", board[i, 1]);//output
        Console.WriteLine("{0} ", board[i, 2]);//output
    }
}

static void placeMarker(string[,] board, string marker, int x_coord, int y_coord)/*creating void function to rewrite * with X or O
                                                                                      * accepts a 2d array of strings, a string, and two ints*/
{
    board[x_coord, y_coord] = marker;//output marker var to element described by xcoord and y coord
}

static int winCheck(string[,] board)//creating an int function to return an int to be used to output who won, accepts a 2d array of strings
{//checking all possible coordinate combos for a win for player 1 or 2 - X or O
    if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X")
    {
        return 1;
    }
    else if (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O")
    {
        return 2;
    }
    else if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X")
    {
        return 1;
    }
    else if (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O")
    {
        return 2;
    }
    else if (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X")
    {
        return 1;
    }
    else if (board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O")
    {
        return 2;
    }
    else if (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X")
    {
        return 1;
    }
    else if (board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O")
    {
        return 2;
    }
    else if (board[0, 0] == "X" && board[1, 0] == "X" && board[2, 0] == "X")
    {
        return 1;
    }
    else if (board[0, 0] == "O" && board[1, 0] == "O" && board[2, 0] == "O")
    {
        return 2;
    }
    else if (board[0, 1] == "X" && board[1, 1] == "X" && board[2, 1] == "X")
    {
        return 1;
    }
    else if (board[0, 1] == "O" && board[1, 1] == "O" && board[2, 1] == "O")
    {
        return 2;
    }
    else if (board[0, 2] == "X" && board[1, 2] == "X" && board[2, 2] == "X")
    {
        return 1;
    }
    else if (board[0, 2] == "O" && board[1, 2] == "O" && board[2, 2] == "O")
    {
        return 2;
    }
    else if (board[2, 0] == "X" && board[1, 1] == "X" && board[0, 2] == "X")
    {
        return 1;
    }
    else if (board[2, 0] == "O" && board[1, 1] == "O" && board[0, 2] == "O")
    {
        return 2;
    }
    else if (board[0, 0] != "*" && board[1, 0] != "*" && board[2, 0] != "*" && board[0, 1] != "*" && board[1, 1] != "*" && board[2, 1] != "*" && board[0, 2] != "*" && board[1, 2] != "*" && board[2, 2] != "*")//if the board is full and none of the above conditions are true
    {
        return 3;//return 3 will say it is a tie
    }
    else//if none of the above are true
    {
        return 0;//return 0 - means loop will continue to run
    }

}
Console.ReadKey();