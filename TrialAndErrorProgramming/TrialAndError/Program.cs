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


    }
    
    class Program
    {
        static void Main(string[] args)
        {             
          
        }
    }
}
