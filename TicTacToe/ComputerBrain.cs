using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TicTacToe
{
    public static class ComputerBrain
    {
        private static readonly Random Rand = new Random();
        public static int GetChoice(Players[] fields)
        {
            int choice;

            // check if computer can make a winning choice
            choice = GetUnusedFieldIndex(fields, Players.Computer);
            if(choice >= 0)
                return choice;

            // check if player has 2 in a row and computer has to choose the one that's left
            choice = GetUnusedFieldIndex(fields, Players.Player);
            if (choice >= 0)
                return choice;

            // if the field in the center is free pick it
            if (fields[4] == Players.None)
                return 4;

            // if a field in the corners is free pick it
            if (fields[8] == Players.None)
                return 8;
            if (fields[6] == Players.None)
                return 6;
            if (fields[2] == Players.None)
                return 2;
            if (fields[0] == Players.None)
                return 0;

            // pick a random position
            return GetRandomChoice(fields);
        }

        private static int GetRandomChoice(Players[] fields)
        {
            while (true)
            {
                int index = Rand.Next(0, fields.Length);
                if (fields[index] == Players.None)
                    return index;
            }
        }

        public static int GetUnusedFieldIndex(Players[] fields, Players player)
        {
            //  winning combinations:
            //  0   1   2       0   3   6       0   4   8
            //  3   4   5       1   4   7       2   4   6
            //  6   7   8       2   5   8

            if (TryGetUnusedFieldIndex(fields, player, 0, 1, 2, out int index))
                return index;
            if (TryGetUnusedFieldIndex(fields, player, 3, 4, 5, out index))
                return index;
            if (TryGetUnusedFieldIndex(fields, player, 6, 7, 8, out index))
                return index;
            if (TryGetUnusedFieldIndex(fields, player, 0, 3, 6, out index))
                return index;
            if (TryGetUnusedFieldIndex(fields, player, 1, 4, 7, out index))
                return index;
            if (TryGetUnusedFieldIndex(fields, player, 2, 5, 8, out index))
                return index;
            if (TryGetUnusedFieldIndex(fields, player, 0, 4, 8, out index))
                return index;
            if (TryGetUnusedFieldIndex(fields, player, 2, 4, 6, out index))
                return index;

            return -1;
        }

        public static bool TryGetUnusedFieldIndex(Players[] fields, Players player, int indexA, int indexB, int indexC, out int result)
        {
            result = -1;
            if (fields[indexA] == player && fields[indexB] == player && fields[indexC] == Players.None)
                result = indexC;
            if (fields[indexA] == player && fields[indexB] == Players.None && fields[indexC] == player)
                result = indexB;
            if (fields[indexA] == Players.None && fields[indexB] == player && fields[indexC] == player)
                result = indexA;
            return result >= 0;
        }
    }
}