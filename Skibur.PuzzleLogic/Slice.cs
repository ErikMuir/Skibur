namespace Skibur.PuzzleLogic
{
    public class Slice
    {
        public char Symbol { get; private set; }
        public Axis Axis { get; private set; }
        public int Index { get; private set; }

        public Slice(char symbol, Axis axis, int index)
        {
            Symbol = symbol;
            Axis = axis;
            Index = index;
        }
    }
}
