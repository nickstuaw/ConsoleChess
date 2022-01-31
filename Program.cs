using System;
using System.Collections.Generic;

namespace CSharpChess
{
    internal enum Piece
    {
        NONE,
        PAWN,
        CASTLE,
        KNIGHT,
        BISHOP,
        QUEEN,
        KING
    }
    internal class DisplayedPiece
    {
        private string[] _lines;
        private Piece _id;
        public DisplayedPiece(Piece id, params string[] lines)
        {
            _id = id;
            _lines = lines;
        }
    }
    class Program
    {
        private List<Piece> board;
        static void Main(string[] args)
        {
            DisplayedPiece pawn = new DisplayedPiece(
                Piece.PAWN,
                "   _   ",
                "  /.\\  ",
                "  \\_/  ",
                " _/_\\_ "),
                castle = new DisplayedPiece(
                    Piece.CASTLE,
                    "|__.__|",
                    "   |   ",
                    " __|__ ",
                    "|_____|"),
                    bishop = new DisplayedPiece(
                        Piece.BISHOP,
                        "   |   ",
                        "  /+\\  ",
                        "  \\|/  ",
                        " _/=\\_ "),
                        knight = new DisplayedPiece(
                            Piece.KNIGHT,
                            " /--\\_ ",
                            "/    _>",
                            "\\__-/_ ",
                            "/_____\\"),
                            queen = new DisplayedPiece(
                                Piece.QUEEN,
                                "|/\\|/\\|",
                                " \\ + / ",
                                "_-/*\\-_",
                                "|=*_*=|"),
                                king = new DisplayedPiece(
                                    Piece.KING,
                                    "|\\ + /|",
                                    "\\_\\|/_/",
                                    " / * \\ ",
                                    "/_____\\");
            string top_line = new string('_', 96);
            string blank_line = new string(' ', 11);
            string bottom_line = new string('_', 11);
            string margin = new string(' ', 2);
        }
    }
}
