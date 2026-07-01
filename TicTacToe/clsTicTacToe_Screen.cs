using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Screen
{
    public class clsTicTacToe_Screen
    {
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
        struct stLinesTextColors
        {
            public string _Line1TextColor;
            public string _Line2TextColor;
            public string _Line3TextColor;
        }
        private stPlacesScreen _PlacesScreen;
        private stLinesTextColors _linesTextColors;


        public clsTicTacToe_Screen(string Place1, string Place2, string Place3, string Place4, string Place5, string Place6, string Place7, string Place8, string Place9,
            string Line1TextColor, string Line2TextColor, string Line3TextColor)
        {
            _PlacesScreen.Place1 = Place1;
            _PlacesScreen.Place2 = Place2;
            _PlacesScreen.Place3 = Place3;
            _PlacesScreen.Place4 = Place4;
            _PlacesScreen.Place5 = Place5;
            _PlacesScreen.Place6 = Place6;   
            _PlacesScreen.Place7 = Place7;
            _PlacesScreen.Place8 = Place8;
            _PlacesScreen.Place9 = Place9;

            _linesTextColors._Line1TextColor = Line1TextColor;
            _linesTextColors._Line2TextColor = Line2TextColor;
            _linesTextColors._Line3TextColor = Line3TextColor;

        }

        private void _Line1()
        {
            if (_linesTextColors._Line1TextColor == null)
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place1}             {_PlacesScreen.Place2}             {_PlacesScreen.Place3}");
            }
            if(_linesTextColors._Line1TextColor == "All")
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.Write($"\n\n                             {_PlacesScreen.Place2}");
                Console.Write($"             {_PlacesScreen.Place1}");
                Console.Write($"             {_PlacesScreen.Place3}");

                Console.ResetColor();
            }

            else if (_linesTextColors._Line1TextColor == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.Write($"\n\n\n                             {_PlacesScreen.Place1}"); Console.ResetColor();

                Console.Write($"             {_PlacesScreen.Place2}");

                Console.Write($"             {_PlacesScreen.Place3}");
            }

            else if (_linesTextColors._Line1TextColor == "2")
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place1}");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("             " + _PlacesScreen.Place2); Console.ResetColor();
                Console.Write($"             {_PlacesScreen.Place3}");
            }

            else if (_linesTextColors._Line1TextColor == "3")
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place1}");
                Console.Write($"             {_PlacesScreen.Place2}");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("             " + _PlacesScreen.Place3); Console.ResetColor();
               
            }
        }
        private void _Line2()
        {
            if (_linesTextColors._Line2TextColor == null)
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place4}             {_PlacesScreen.Place5}             {_PlacesScreen.Place6}");
            }
            if (_linesTextColors._Line2TextColor == "All")
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.Write($"\n\n\n                             {_PlacesScreen.Place4}");
                Console.Write($"             {_PlacesScreen.Place5}");
                Console.Write($"             {_PlacesScreen.Place6}");

                Console.ResetColor();
            }

            else if (_linesTextColors._Line2TextColor == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.Write($"\n\n\n                             {_PlacesScreen.Place4}"); Console.ResetColor();

                Console.Write($"             {_PlacesScreen.Place5}");

                Console.Write($"             {_PlacesScreen.Place6}");
            }

            else if (_linesTextColors._Line2TextColor == "2")
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place4}");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("             " + _PlacesScreen.Place5); Console.ResetColor();
                Console.Write($"             {_PlacesScreen.Place6}");
            }

            else if (_linesTextColors._Line2TextColor == "3")
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place4}");
                Console.Write($"             {_PlacesScreen.Place5}");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("             " + _PlacesScreen.Place6); Console.ResetColor();

            }
        }
        private void _Line3()
        {
            if (_linesTextColors._Line3TextColor == null)
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place7}             {_PlacesScreen.Place8}             {_PlacesScreen.Place9}\n");
            }
            if (_linesTextColors._Line3TextColor == "All")
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.Write($"\n\n\n                             {_PlacesScreen.Place7}");
                Console.Write($"             {_PlacesScreen.Place8}");
                Console.Write($"             {_PlacesScreen.Place9}");

                Console.ResetColor();
            }

            else if (_linesTextColors._Line3TextColor == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.Write($"\n\n\n                             {_PlacesScreen.Place7}"); Console.ResetColor();

                Console.Write($"             {_PlacesScreen.Place8}");

                Console.Write($"             {_PlacesScreen.Place9}");
            }

            else if (_linesTextColors._Line3TextColor == "2")
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place7}");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("             " + _PlacesScreen.Place8); Console.ResetColor();
                Console.Write($"             {_PlacesScreen.Place9}");
            }

            else if (_linesTextColors._Line3TextColor == "3")
            {
                Console.Write($"\n\n\n                             {_PlacesScreen.Place7}");
                Console.Write($"             {_PlacesScreen.Place8}");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write("             " + _PlacesScreen.Place9); Console.ResetColor();
                Console.WriteLine("\n");

            }
        }


        public void SetScreen()
        {
            _Line1();
            _Line2();
            _Line3();
            
        }
    }

   
              

}
