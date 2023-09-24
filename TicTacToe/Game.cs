using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        private Board Board { get; } = new Board();
        private Marker CurrentMarker { get; set; } = Marker.Y;
        private bool GameOver { get; set; }

        public void Play()
        {

            while (!GameOver)
            {
                //DrawBoard();
                Console.Clear();

                SwitchMarker();

                Console.WriteLine($"Current turn: {CurrentMarker}");

                PromptCurrentPlayer();

                GameOver = Board.CheckWinningCondition(CurrentMarker);
            }
        }

        private void PromptCurrentPlayer()
        {
            bool isInputValid = false;
            Console.WriteLine("Please select a position (0-8)");

            while (!isInputValid)
            {
                string input = Console.ReadLine() ?? string.Empty;

                int position;
                if (!(int.TryParse(input, out position) && position >= 0 && position <= 8))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (!Board.PutMarker(position, CurrentMarker))
                {
                    Console.WriteLine($"A marker already exists on position {position}");
                    continue;
                }

                isInputValid = true;
            }
        }

        private void DrawBoard()
        {
            //TODO: Implement DrawBoard
            throw new NotImplementedException();
        }

        private void SwitchMarker()
        {
            if (CurrentMarker == Marker.X)
            {
                CurrentMarker = Marker.Y;
            }
            else
            {
                CurrentMarker = Marker.X;
            }
        }
    }
}

