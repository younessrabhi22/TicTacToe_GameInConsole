﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_Screen;

namespace TicTacToe
{
    internal class Program
    {


        public class clsTicTocToe_Main
        {
            enum enWinner { Player1 = 1, Player2 = 2, Computer = 3, Draw = 4 };

            enWinner _Winner;



            bool _GameOver = false;
            bool _Player2IsComputer = false;
            private short _Counter;
             struct stPlacesScreen
            {
                public string Place1;
                public string Place2;
                public string Place3;
                public string Place4;
                public string Place5;
                public string Place6;
                public string Place7;
                public string Place8;
                public string Place9;
            };
            struct stXOPlaces

            {

		        public bool N1 ;
                public bool N2 ;
                public bool N3 ;
                public bool N4 ;
                public bool N5 ;
                public bool N6 ;
                public bool N7 ;
                public bool N8 ;
                public bool N9 ;
            };

            struct stLinesTextColors
            {
                public string _Line1TextColor;
                public string _Line2TextColor;
                public string _Line3TextColor;
            }
            private stPlacesScreen _PlacesScreen;
            private stLinesTextColors _linesTextColors;



            private stXOPlaces _XOPlaces;
            private string _WinnerName()
            {
                switch (_Winner)
                {

                    case enWinner.Player1:
                        return "Player 1";

                    case enWinner.Player2:
                        return "Player 2";

                    case enWinner.Computer:
                        return "Computer";

                    default:
                        return "Draw Game";

                }
            }
            public clsTicTocToe_Main()
            {
                _PlacesScreen.Place1 = "1";
                _PlacesScreen.Place2 = "2";
                _PlacesScreen.Place3 = "3";
                _PlacesScreen.Place4 = "4";
                _PlacesScreen.Place5 = "5";
                _PlacesScreen.Place6 = "6";
                _PlacesScreen.Place7 = "7";
                _PlacesScreen.Place8 = "8";
                _PlacesScreen.Place9 = "9";

                _XOPlaces.N1 = true;
                _XOPlaces.N2 = true;
                _XOPlaces.N3 = true;
                _XOPlaces.N4 = true;
                _XOPlaces.N5 = true;
                _XOPlaces.N6 = true;
                _XOPlaces.N7 = true;
                _XOPlaces.N8 = true;
                _XOPlaces.N9 = true;
        }


            private short _ComputerChoice()
            {
                int RandomNumber = 0;
                bool IsValid = false;


                while (!IsValid)
                {
                    Random random = new Random();
                     RandomNumber = random.Next(1, 9);

                    if (RandomNumber == 1 && _PlacesScreen.Place1 == "1")
                    {
                        _XOPlaces.N1 = false;
                        IsValid = true;
                        break;
                    }
                    else if (RandomNumber == 2 && _PlacesScreen.Place2 == "2")
                    {
                        _XOPlaces.N2 = false;
                        IsValid = true;
                        break;
                    }
                    else if (RandomNumber == 3 && _PlacesScreen.Place3 == "3")
                    {
                        _XOPlaces.N3 = false;
                        IsValid = true;
                        break;
                    }
                    else if(RandomNumber == 4 && _PlacesScreen.Place4 == "4")
                    {
                        _XOPlaces.N4 = false;
                        IsValid = true;
                        break;
                    }
                    else if(RandomNumber == 5 && _PlacesScreen.Place5 == "5")
                    {
                        _XOPlaces.N5 = false;
                        IsValid = true;
                        break;
                    }
                    else if(RandomNumber == 6 && _PlacesScreen.Place6 == "6")
                    {
                        _XOPlaces.N6 = false;
                        IsValid = true;
                        break;
                    }
                    else if(RandomNumber == 7 && _PlacesScreen.Place7 == "7")
                    {
                        _XOPlaces.N7 = false;
                        IsValid = true;
                        break;
                    }
                    else if(RandomNumber == 8 && _PlacesScreen.Place8 == "8")
                    {
                        _XOPlaces.N8 = false;
                        IsValid = true;
                        break;
                    }
                    else if(RandomNumber == 9 && _PlacesScreen.Place9 == "9")
                    {
                        _XOPlaces.N9 = false;
                        IsValid = true;
                        break;
                    }

                }


                    return (short)RandomNumber;
                }
            private bool _IsValidNumber(string Choice)
            {
                bool IsValid = short.TryParse(Choice, out short result);
                return IsValid;
            }
            private bool _ChekTheChoice(short Choice)
            {
                if (Choice < 1 || Choice > 9)
                {

                    return false;
                }

                switch (Choice)
                {

                    case 1:
                        if (_XOPlaces.N1)
                        {
                            _XOPlaces.N1 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case 2:
                        if (_XOPlaces.N2)
                        {
                            _XOPlaces.N2 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case 3:

                        if (_XOPlaces.N3)
                        {
                            _XOPlaces.N3 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case 4:

                        if (_XOPlaces.N4)
                        {
                            _XOPlaces.N4 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 5:

                        if (_XOPlaces.N5)
                        {
                            _XOPlaces.N5 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 6:

                        if (_XOPlaces.N6)
                        {
                            _XOPlaces.N6 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 7:

                        if (_XOPlaces.N7)
                        {
                            _XOPlaces.N7 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 8:

                        if (_XOPlaces.N8)
                        {
                            _XOPlaces.N8 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 9:

                        if (_XOPlaces.N9)
                        {
                            _XOPlaces.N9 = false;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                }
                return false;
            }
            private short _Player1Choice()
            {
                       string   Choice;
                       Console.WriteLine("Player 1 Choice ?");
                       Choice = Console.ReadLine();
                while (!_IsValidNumber(Choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Please enter a number!");
                    Console.ResetColor();
                    Choice = Console.ReadLine();
                }

                while (!_ChekTheChoice(Convert.ToInt16(Choice)))
                       {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid! Enter Again ?");
                    Console.ResetColor();

                    Choice = Console.ReadLine();
                }


                return Convert.ToInt16(Choice);

                   }
            private short _Player2Choice()
                   {

                string Choice;
                Console.WriteLine("Player 2 Choice ?");
                Choice = Console.ReadLine();
                while (!_IsValidNumber(Choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number!");
                    Console.ResetColor();
                    Choice = Console.ReadLine();
                }

                while (!_ChekTheChoice(Convert.ToInt16(Choice)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid! Enter Again ?");
                    Console.ResetColor();
                    Choice = Console.ReadLine();
                }


                return Convert.ToInt16(Choice);

            }

            private bool _GameScreen()
            {

                Console.Clear();

                clsTicTacToe_Screen TicTacToe_Screen = new clsTicTacToe_Screen(_PlacesScreen.Place1, _PlacesScreen.Place2, _PlacesScreen.Place3, _PlacesScreen.Place4,
                              _PlacesScreen.Place5, _PlacesScreen.Place6, _PlacesScreen.Place7,
                              _PlacesScreen.Place8, _PlacesScreen.Place9, _linesTextColors._Line1TextColor, _linesTextColors._Line2TextColor, _linesTextColors._Line3TextColor);


                TicTacToe_Screen.SetScreen();


                return _GameOver = _ChekWinner();

            }

            private void _SelectTheCorectPlace(short Place, short Player)
            {

                switch (Place)
                {
                    case 1:
                        _PlacesScreen.Place1 = (Player == 1) ? "X" : "O";

                        break;

                    case 2:
                        _PlacesScreen.Place2 = (Player == 1) ? "X" : "O";
                        break;

                    case 3:
                        _PlacesScreen.Place3 = (Player == 1) ? "X" : "O";
                        break;

                    case 4:
                        _PlacesScreen.Place4 = (Player == 1) ? "X" : "O";
                        break;

                    case 5:
                        _PlacesScreen.Place5 = (Player == 1) ? "X" : "O";
                        break;

                    case 6:
                        _PlacesScreen.Place6 = (Player == 1) ? "X" : "O";
                        break;

                    case 7:
                        _PlacesScreen.Place7 = (Player == 1) ? "X" : "O";
                        break;

                    case 8:
                        _PlacesScreen.Place8 = (Player == 1) ? "X" : "O";
                        break;

                    case 9:
                        _PlacesScreen.Place9 = (Player == 1) ? "X" : "O";
                        break;
                }


            }

            private bool _Player1WinProbabilities()
            {

                if (_PlacesScreen.Place1 == "X" && _PlacesScreen.Place2 == "X" && _PlacesScreen.Place3 == "X")
                {
                    _linesTextColors._Line1TextColor = "All";
                    _Winner = enWinner.Player1;

                    return true;
                }
                if (_PlacesScreen.Place4 == "X" && _PlacesScreen.Place5 == "X" && _PlacesScreen.Place6 == "X")
                {
                    _linesTextColors._Line2TextColor = "All";
                    _Winner = enWinner.Player1;
                    return true;
                }
                if (_PlacesScreen.Place7 == "X" && _PlacesScreen.Place8 == "X" && _PlacesScreen.Place9 == "X")
                {
                    _linesTextColors._Line3TextColor = "All";
                    _Winner = enWinner.Player1;
                    return true;
                }
                if (_PlacesScreen.Place1 == "X" && _PlacesScreen.Place4 == "X" && _PlacesScreen.Place7 == "X")
                {
                    _linesTextColors._Line1TextColor = "1";
                    _linesTextColors._Line2TextColor = "1";
                    _linesTextColors._Line3TextColor = "1";

                    _Winner = enWinner.Player1;
                    return true;
                }
                if (_PlacesScreen.Place2 == "X" && _PlacesScreen.Place5 == "X" && _PlacesScreen.Place8 == "X")
                {
                    _linesTextColors._Line1TextColor = "2";
                    _linesTextColors._Line2TextColor = "2";
                    _linesTextColors._Line3TextColor = "2";

                    _Winner = enWinner.Player1;
                    return true;
                }
                if (_PlacesScreen.Place3 == "X" && _PlacesScreen.Place6 == "X" && _PlacesScreen.Place9 == "X")
                {
                    _linesTextColors._Line1TextColor = "3";
                    _linesTextColors._Line2TextColor = "3";
                    _linesTextColors._Line3TextColor = "3";

                    _Winner = enWinner.Player1;
                    return true;
                }
                if (_PlacesScreen.Place1 == "X" && _PlacesScreen.Place5 == "X" && _PlacesScreen.Place9 == "X")
                {
                    _linesTextColors._Line1TextColor = "1";
                    _linesTextColors._Line2TextColor = "2";
                    _linesTextColors._Line3TextColor = "3";

                    _Winner = enWinner.Player1;
                    return true;
                }
                if (_PlacesScreen.Place3 == "X" && _PlacesScreen.Place5 == "X" && _PlacesScreen.Place7 == "X")
                {
                    _linesTextColors._Line1TextColor = "3";
                    _linesTextColors._Line2TextColor = "2";
                    _linesTextColors._Line3TextColor = "1";
                    _Winner = enWinner.Player1;
                    return true;
                }
                return false;

            }

             private bool _Player2WinProbabilities()
            {

                if (_PlacesScreen.Place1 == "O" && _PlacesScreen.Place2 == "O" && _PlacesScreen.Place3 == "O")
                {
                    _linesTextColors._Line1TextColor = "All";

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;

                    return true;
                }
                if (_PlacesScreen.Place4 == "O" && _PlacesScreen.Place5 == "O" && _PlacesScreen.Place6 == "O")
                {
                    _linesTextColors._Line2TextColor = "All";

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;
                    return true;
                }
                if (_PlacesScreen.Place7 == "O" && _PlacesScreen.Place8 == "O" && _PlacesScreen.Place9 == "O")
                {
                    _linesTextColors._Line3TextColor = "All";

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;
                    return true;
                }
                if (_PlacesScreen.Place1 == "O" && _PlacesScreen.Place4 == "O" && _PlacesScreen.Place7 == "O")
                {
                    _linesTextColors._Line1TextColor = "1";
                    _linesTextColors._Line2TextColor = "1";
                    _linesTextColors._Line3TextColor = "1";

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;
                    return true;
                }
                if (_PlacesScreen.Place2 == "O" && _PlacesScreen.Place5 == "O" && _PlacesScreen.Place8 == "O")
                {
                    _linesTextColors._Line1TextColor = "2";
                    _linesTextColors._Line2TextColor = "2";
                    _linesTextColors._Line3TextColor = "2";

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;
                    return true;
                }
                if (_PlacesScreen.Place3 == "O" && _PlacesScreen.Place6 == "O" && _PlacesScreen.Place9 == "O")
                {
                    _linesTextColors._Line1TextColor = "3";
                    _linesTextColors._Line2TextColor = "3";
                    _linesTextColors._Line3TextColor = "3";

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;
                    return true;
                }
                if (_PlacesScreen.Place1 == "O" && _PlacesScreen.Place5 == "O" && _PlacesScreen.Place9 == "O")
                {
                    _linesTextColors._Line1TextColor = "1";
                    _linesTextColors._Line2TextColor = "2";
                    _linesTextColors._Line3TextColor = "3";

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;
                    return true;
                }
                if (_PlacesScreen.Place3 == "O" && _PlacesScreen.Place5 == "O" && _PlacesScreen.Place7 == "O")
                {
                    _linesTextColors._Line1TextColor = "3";
                    _linesTextColors._Line2TextColor = "2";
                    _linesTextColors._Line3TextColor = "1";
                    _Winner = enWinner.Player1;

                    _Winner = (_Player2IsComputer) ? enWinner.Computer : enWinner.Player2;
                    return true;
                }
                return false;

            }

           private bool _ChekWinner()
            {



                if (_Player1WinProbabilities() || _Player2WinProbabilities() || _Counter == 9)
                {
                    return true;
                }



                return false;
            }

            private bool Rounds()
            {
                while (!_GameOver)
                {

                    short Choice = _Player1Choice();
                    _Counter++;
                    _SelectTheCorectPlace(Choice, 1);
                    if (_GameScreen())
                    {
                        return true;
                    };

                    if (_Player2IsComputer)
                    {
                        Choice = _ComputerChoice();
                        _Counter++;
                    }
                    else
                    {
                        Choice = _Player2Choice();
                        _Counter++;
                    }

                    _SelectTheCorectPlace(Choice, 2);
                    _GameScreen();


                }

                return true;
            }

            private void _EndGame()
            {


                if (_Player1WinProbabilities() || _Player2WinProbabilities())
                {
                    if(_WinnerName() == "Player 1"|| _WinnerName() == "Player 2" || _WinnerName() == "Computer")
                    {
                        Console.Write("\n\n\aThe Winner Is :  ");

                        if(_WinnerName() == "Computer")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        Console.Write(_WinnerName()+"\n");

                        Console.ResetColor();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nDraw Game");
                    Console.ResetColor();
                }



            }
            private void _RestartGame()
            {
                _PlacesScreen.Place1 = "1";
                _PlacesScreen.Place2 = "2";
                _PlacesScreen.Place3 = "3";
                _PlacesScreen.Place4 = "4";
                _PlacesScreen.Place5 = "5";
                _PlacesScreen.Place6 = "6";
                _PlacesScreen.Place7 = "7";
                _PlacesScreen.Place8 = "8";
                _PlacesScreen.Place9 = "9";

                _XOPlaces.N1 = true;
                _XOPlaces.N2 = true;
                _XOPlaces.N3 = true;
                _XOPlaces.N4 = true;
                _XOPlaces.N5 = true;
                _XOPlaces.N6 = true;
                _XOPlaces.N7 = true;
                _XOPlaces.N8 = true;
                _XOPlaces.N9 = true;

                _linesTextColors._Line1TextColor = null;
                _linesTextColors._Line2TextColor = null;
                _linesTextColors._Line3TextColor = null;

                _Player2IsComputer = false;
                _Counter = 0;
            }

            private void _ChooseThePlayer2()
            {

                Console.WriteLine("\nYou Want To Play With The Computer Or Your Friend?\n");

                Console.Write("Computer   "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("  [1]"); Console.ResetColor();
                Console.Write("\nYour Friend"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("  [2]\n"); Console.ResetColor();
                string choice = Console.ReadLine();



                while (!_IsValidNumber(choice) || (Convert.ToInt16(choice) < 1 || Convert.ToInt16(choice) > 2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Number! Enter Again?");
                    Console.ResetColor();

                    choice = Console.ReadLine();
                }

                _Player2IsComputer = (choice == "1") ? true : false;
            }
            public void StartGame()

            {
                Console.Clear();
                _ChooseThePlayer2();
                Console.Clear();

                _GameScreen();



                if (Rounds())
                {
                    Console.Clear();

                    clsTicTacToe_Screen TicTacToe_Screen = new clsTicTacToe_Screen(_PlacesScreen.Place1, _PlacesScreen.Place2, _PlacesScreen.Place3, _PlacesScreen.Place4,
                             _PlacesScreen.Place5, _PlacesScreen.Place6,
                             _PlacesScreen.Place7, _PlacesScreen.Place8, _PlacesScreen.Place9, _linesTextColors._Line1TextColor, _linesTextColors._Line2TextColor, _linesTextColors._Line3TextColor);


                    TicTacToe_Screen.SetScreen();
                    _EndGame();

                    string Choice;
                    Console.WriteLine("\nDo Want to Play Again? Y or N"); Choice = Console.ReadLine();
                    if(Choice.ToUpper() == "Y")
                    {
                        _RestartGame();
                        this.StartGame();
                    }
                    else
                    {
                        return;
                    }
                }


            }

            static void Main(string[] args)
            {

                clsTicTocToe_Main obj = new clsTicTocToe_Main();
                obj.StartGame();



                Console.WriteLine("\n\n\n\n\n");
                //Console.ReadKey();
            }
        }
    }
}
