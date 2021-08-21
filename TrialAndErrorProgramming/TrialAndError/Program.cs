using System;

namespace TrialAndError
{
    class WalkHorse 
    {
        //Horse movement coordinates
        int[] dx = {2, 1, -1, -2, -2, -1, 1, 2};
        int[] dy = {1, 2, 2, 1, -1, -2, -2, -1};

        //Number of positions of board
        int NumberPosition;

        //Number of houses of board
        int NumberHouses;

        //Board
        int [,] Board;

        public WalkHorse(int _numberPosition)
        {
            NumberPosition = _numberPosition;
            NumberHouses = NumberPosition * NumberPosition;
            Board = new int[NumberPosition,NumberPosition];
        }
        
        private bool Acceptable(int x, int y)
        {
            bool Result = (x >= 0 && x <= NumberPosition - 1);
            Result = Result && (y >= 0 && y <= NumberPosition - 1);
            Result = Result && (Board[x,y] == 0);

            return Result;
        }

        bool TryWalk(int Walks,int x,int y)
        {
           bool Match = (Walks > NumberHouses);

           int k = 0, u ,v ;

           while (!Match && k < 8)
           {
               u = x + dx[k];
               v = y + dy[k];

               if (Acceptable(u,v))
               {
                   Board[u,v] = Walks; //Regiter Walks
                   Match = TryWalk(Walks + 1, u ,v); //Go back

                   if (!Match)
                   {
                       Board[u,v] = 0; //No success
                   }
               }
               k++;
           }

           return Match;
        }

        public void FootprintHorse(int x, int y) 
        {
           Board[x , y] = 1;

           bool Match = TryWalk(2 , x ,y);

           if (Match)
           {
               for (int i = 0; i < Board.GetLength(0); i++)
               {
                   for (int j = 0; j < Board.GetLength(1); j++)
                   {
                       Console.Write(Board[i,j] + "\t");
                   }
                   Console.WriteLine();
               }
           }
           else 
           {
               Console.WriteLine("Não achou um passeio do cavalo!");
           }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {             
          
          WalkHorse Horse = new WalkHorse(5);

          Horse.FootprintHorse(2,2);
    
        }
    }
}
