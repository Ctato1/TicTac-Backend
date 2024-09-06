using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    internal class Program
    {

        static string[,] board =
            {
                {"1","2","3"},
                {"4","5", "6"},
                {"7", "8","9"}
            };
        static int moves = 0;
        static bool isOver = false;
        static void Main(string[] args)
        {   
            // is valid to continue game?
            
            //check player
            bool isFirstPlayer = true;
            //player1-O; player2-X

            //repeat until game over
            while (isOver == false) {
                CheckBoard();
                Console.WriteLine("{0}: Choose your field",isFirstPlayer ? "Player 1" : "Player 2");
                
                string userInput = Console.ReadLine();
                Console.WriteLine();
                int userValue;
                try
                {
                      userValue = int.Parse(userInput);

                      switch(userValue.ToString())
                      {
                        case "1":
                            if (board[0, 0] == "1")
                            {
                                board[0, 0] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            
                            break;
                        case "2":
                            if (board[0, 1] == "2")
                            {
                                board[0, 1] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                        case "3":
                            if (board[0, 2] == "3")
                            {
                                board[0, 2] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                        case "4":
                            if (board[1, 0] == "4")
                            {
                                board[1, 0] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                        case "5":
                            if (board[1, 1] == "5")
                            {
                                board[1, 1] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                        case "6":
                            if (board[1, 2] == "6")
                            {
                                board[1, 2] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                        case "7":
                            if (board[2, 0] == "7")
                            {
                                board[2, 0] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                        case "8":
                            if (board[2, 1] == "8")
                            {
                                board[2, 1] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                        case "9":
                            if (board[2, 2] == "9")
                            {
                                board[2, 2] = isFirstPlayer ? "O" : "Y";
                                moves++;
                            }
                            else
                            {
                                Console.WriteLine("You can not enter this value it is already taken!");
                                throw new Exception("You can not enter this value it is already taken!");
                            }
                            break;
                      }
                    isFirstPlayer = !isFirstPlayer;
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter only number between 0-9");
                }
                
                if (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O" || board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O" || board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O"||
                  board[0, 0] == "O" && board[1, 0] == "O" && board[2, 0] == "O" || board[0, 1] == "O" && board[1, 1] == "O" && board[2, 1] == "O" || board[0, 2] == "O" && board[1, 2] == "O" && board[2, 2] == "O" ||
                  board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O" || board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O"
                    )
                {
                    CheckBoard();
                    Console.WriteLine("Player 1 Won the game");
                    ResetGame();
                   
                }
                else if(
                  board[0, 0] == "Y" && board[0, 1] == "Y" && board[0, 2] == "Y" || board[1, 0] == "Y" && board[1, 1] == "Y" && board[1, 2] == "Y" || board[2, 0] == "Y" && board[2, 1] == "Y" && board[2, 2] == "Y" ||
                  board[0, 0] == "Y" && board[1, 0] == "Y" && board[2, 0] == "Y" || board[0, 1] == "Y" && board[1, 1] == "Y" && board[2, 1] == "Y" || board[0, 2] == "Y" && board[1, 2] == "Y" && board[2, 2] == "Y" ||
                  board[0, 0] == "Y" && board[1, 1] == "Y" && board[2, 2] == "Y" || board[0, 2] == "Y" && board[1, 1] == "Y" && board[2, 0] == "Y"
                  )
                {
                    CheckBoard();
                    Console.WriteLine("Player 2 Won the game");
                    ResetGame();
                }
                CheckLastMove();

            }

            Console.Read();
        }

        static void CheckBoard()
        {
                Console.WriteLine("{0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("---------");
                Console.WriteLine("{0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("---------");
                Console.WriteLine("{0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);
                Console.WriteLine();
                Console.WriteLine();
        }

        static void ResetGame()
        {
            Console.WriteLine("Reset game? Press 'Y'");
            Console.WriteLine("for Quit Press 'Q' or other keys");
            string askUser = Console.ReadLine();
            if (askUser.ToLower().Equals("y"))
            {
                board = new string[,]
               {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
               };
            }
            else
            {
                isOver = true;
            }
            moves = 0;
        }

        static void CheckLastMove()
        {
            if (moves == 9)
            {
                Console.WriteLine("Draw");
                ResetGame();
            }
        }
    }
}
