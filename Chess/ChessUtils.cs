﻿using Chess.Pieces;
using Core;
using static Chess.Program;

namespace Chess
{
    public static class ChessUtils
    {
        public static bool IsValidPosition(int row, int col)
        {
            return (row < Configuration.ROWS && row >= 0) && ((col < Configuration.COLS && col >= 0));
        }

        public static bool IsValidPosition(Point point) => IsValidPosition(point.Y, point.X);

        public static PlayerTypes GetOtherPlayer(this PlayerTypes player)
        {
            return (((int)player) ^ 1).TryParseToEnum<PlayerTypes>();
        }
    }
}