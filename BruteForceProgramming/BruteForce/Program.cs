using System;
using System.Collections.Generic;

namespace BruteForce
{

    class Itens
    {
        public int Value { get; set; }

        public int Weight { get; set; }

        public Itens(int _value = 0, int _weight = 0)
        {
            Value = _value;
            Weight = _weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Bag = 15;

            List<Itens> ListItens = new()
            {
                new Itens(12, 4),
                new Itens(2, 2),
                new Itens(1, 1),
                new Itens(4, 10),
                new Itens(1, 2)
            };

            BruteForce(ListItens, Bag);
        }
        static int BruteForce(List<Itens> itens, int Bag) 
        {
            string ResultCombination = "";

            int BestValue = 0;
            int OccupiedWeight = 0;
            int TotalItens = itens.Count;
            int Combinations = (int)Math.Pow(2, TotalItens);


            for (int i = 0; i < Combinations; i++)
            {
                int ValueTotal = 0;
                int WeightTotal = 0;

                string Binary = Convert.ToString(i, 2);
                Binary = Binary.PadLeft(TotalItens, '0');

                for (int j = 0; j < TotalItens; j++)
                {
                    if (Binary[j] != '0')
                    {
                        WeightTotal += itens[j].Weight;
                        ValueTotal += itens[j].Value;
                    }
                }

                Console.WriteLine($"{Binary} - Peso: {WeightTotal} \nValor: {ValueTotal} \n");

                if (ValueTotal <= Bag && ValueTotal > BestValue)
                {
                    ResultCombination = Binary;
                    BestValue = ValueTotal;
                    OccupiedWeight = WeightTotal;

                }
            }

            Console.WriteLine($"\n\nA Melhor opção é : {ResultCombination} \nPeso: {OccupiedWeight} \nValor: {BestValue}");

            return 0;
        }
    }
}
