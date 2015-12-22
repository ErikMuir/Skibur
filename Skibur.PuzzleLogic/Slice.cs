using static Skibur.PuzzleLogic.Enums;

namespace Skibur.PuzzleLogic
{
    public class Slice
    {
        public char Symbol { get; set; }
        public Axis Axis { get; set; }
        public int Index { get; set; }

        public Slice(char symbol, Axis axis, int index)
        {
            Symbol = symbol;
            Axis = axis;
            Index = index;
        }
    }
}
