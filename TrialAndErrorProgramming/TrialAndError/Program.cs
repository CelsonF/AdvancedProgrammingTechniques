using System;

namespace TrialAndError
{
    
    class WalkHorse 
    {
        //Horse movement coordinates
        int[] dx = {2, 1, -1, -2, -2, -1, 1, 2};
        int[] dy = {1, 2, 2, 1, -1, -2, -2, -1};

        //Number of positions of board
        int NumberPositions;

        //Number of houses of board
        int NumberHouses;

        //Board
        int [,] Board;

        public WalkHorse(int _numberPosition)
        {
            NumberPositions = _numberPosition;
            NumberHouses = NumberPositions * NumberPositions;
            Board = new int[NumberPositions,NumberPositions]
        }

        private bool Acceptable(int x,int y)
        {
            bool Result = (x >= 0 && x <= NumberPositions - 1);
            Result = Result && (y >= 0 && y <= NumberPositions - 1);
            Result = Result && (Board[x,y] == 0);

            return result;
        }

        bool TryMoviment() {
            
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {             
          
        }
    }
}
