using System;
using System.Collections.Generic;
using System.Drawing;

namespace AttackSolver
{
    public enum ChessmanType
    {
        Rook, // ладья
        Bishop // слон
    }

    public interface IAttackCounter
    {
        /// <summary>
        /// Returns number of points which are under attack 
        /// </summary>
        /// <param name="boardSize"></param>
        /// <param name="startCoords"></param>
        /// <param name="obstacles"></param>
        /// <returns></returns>
        int CountUnderAttack(ChessmanType cmType, Size boardSize, Point startCoords, Point[] obstacles);
    }

    public class MyNaiveAttackCounter : IAttackCounter
    {
        public int CountUnderAttack(ChessmanType cmType, Size boardSize, Point startCoords, Point[] obstacles)
        {
            if (cmType == ChessmanType.Bishop)
                return 3;
            return 2;
        }
    }
}
