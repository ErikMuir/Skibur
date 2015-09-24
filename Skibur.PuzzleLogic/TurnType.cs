namespace Skibur.PuzzleLogic
{
    public class TurnType
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int TurnCount { get; set; }

        public TurnType(string name, string symbol, int turnCount)
        {
            Name = name;
            Symbol = symbol;
            TurnCount = turnCount;
        }
    }
}
