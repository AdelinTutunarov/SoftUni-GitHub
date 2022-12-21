using System;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 3)
            {
                Console.WriteLine(0);
                return;
            }
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int removedKnights = 0;
            while (true)
            {
                int mostAttackingKnight = 0;
                int mostAttackingKnightRow = 0;
                int mostAttackingKnightCol = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(matrix, n, i, j);
                            if (attackedKnights > mostAttackingKnight)
                            {
                                mostAttackingKnight = attackedKnights;
                                mostAttackingKnightRow = i;
                                mostAttackingKnightCol = j;
                            }
                        }
                    }
                }
                if (mostAttackingKnight == 0) break;
                else
                {
                    matrix[mostAttackingKnightRow, mostAttackingKnightCol] = '0';
                    removedKnights++;
                }
            }
            Console.WriteLine(removedKnights);
        }

        private static int CountAttackedKnights(char[,] matrix, int n, int i, int j)
        {
            int attackedKnights = 0;
            if (CheckCell(i - 2, j + 1, n))
            {
                if (matrix[i - 2, j + 1] == 'K') attackedKnights++;
            }
            if (CheckCell(i - 1, j + 2, n))
            {
                if (matrix[i - 1, j + 2] == 'K') attackedKnights++;
            }
            if (CheckCell(i + 1, j + 2, n))
            {
                if (matrix[i + 1, j + 2] == 'K') attackedKnights++;
            }
            if (CheckCell(i + 2, j + 1, n))
            {
                if (matrix[i + 2, j + 1] == 'K') attackedKnights++;
            }
            if (CheckCell(i + 2, j - 1, n))
            {
                if (matrix[i + 2, j - 1] == 'K') attackedKnights++;
            }
            if (CheckCell(i + 1, j - 2, n))
            {
                if (matrix[i + 1, j - 2] == 'K') attackedKnights++;
            }
            if (CheckCell(i - 1, j - 2, n))
            {
                if (matrix[i - 1, j - 2] == 'K') attackedKnights++;
            }
            if (CheckCell(i - 2, j - 1, n))
            {
                if (matrix[i - 2, j - 1] == 'K') attackedKnights++;
            }
            return attackedKnights;
        }

        private static bool CheckCell(int i, int j, int n)
        {
            return i >= 0 && i < n && j >= 0 && j < n;
        }
    }
}
