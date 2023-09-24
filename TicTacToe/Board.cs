using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public Marker?[] Markers { get; private set; } = new Marker?[9] { null, null, null, null, null, null, null, null, null, };

        public bool PutMarker(int position, Marker marker)
        {
            if (Markers[position] == null)
            {
                Markers[position] = marker;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Marker? GetMarkerOn(int position)
        {
            return Markers[position];
        }

        public void ClearBoard()
        {
            Markers = new Marker?[9] { null, null, null, null, null, null, null, null, null, };
        }

        public bool CheckWinningCondition(Marker marker)
        {
            return
            //Rows
               (marker == Markers[0] && marker == Markers[1] && marker == Markers[2])
            || (marker == Markers[3] && marker == Markers[4] && marker == Markers[5])
            || (marker == Markers[6] && marker == Markers[7] && marker == Markers[8])

            //Columns
            || (marker == Markers[0] && marker == Markers[3] && marker == Markers[6])
            || (marker == Markers[1] && marker == Markers[4] && marker == Markers[7])
            || (marker == Markers[2] && marker == Markers[5] && marker == Markers[8])

            //Diagonals
            || (marker == Markers[0] && marker == Markers[4] && marker == Markers[8])
            || (marker == Markers[2] && marker == Markers[4] && marker == Markers[6]);
        }
    }
}
