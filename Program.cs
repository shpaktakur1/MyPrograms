using System;
using System.ComponentModel;
using System.Numerics;
using System.Text;
using Z_HomeWork.TicTacToe;

namespace Z_HomeWork
{
     class Program
     {
        private static TicTacToeGame g = new TicTacToeGame();
        static void Main(string[] args)
       {
            Console.WriteLine(GetPrintableState());

            while(g.GetWinner() == Winner.GameIsUnFinished)
            {
                int index = int.Parse(Console.ReadLine());
                g.MakeMove(index);

                Console.WriteLine();
                Console.WriteLine(GetPrintableState());
            }

            Console.WriteLine($"Result: {g.GetWinner()}");
            Console.ReadLine();
       }

        static string GetPrintableState()
        {
            var sb = new StringBuilder();
            for(int i = 1; i<=7; i += 3)
            {
                sb.AppendLine("     |     |     |")
                    .AppendLine(
                    $"  {GetPrintableChar(i)}  |  {GetPrintableChar(i + 1)}  |  {GetPrintableChar(i + 2)}  |")
                    .AppendLine("_____|_____|_____|");
                   
            }
            return sb.ToString();
        }
        static string GetPrintableChar(int index)
        {
            State state = g.GetState(index);
            if (state == State.Unset)
                return index.ToString();
            return state == State.Cross ? "X" : "O";
        }

        
        static void GuessNumberGame()
        {
            GuessNumberGame game = new GuessNumberGame(guessingPlayer: GuessingPlayer.Machine);
            game.Start();

            Console.ReadLine();
        }
        static void ComplexNumbers()
        {
            //Complex c1 = new Complex(1, 1);
            //Complex c2 = new Complex(1, 2);

            //Complex result = c1.Plus(c2);
            //Console.WriteLine($"result. Real ={result.Real}; Imaginary={result.Imaginary}");
        }
     }
}
