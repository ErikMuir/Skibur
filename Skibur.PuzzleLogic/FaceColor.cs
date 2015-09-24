using System.Drawing;

namespace Skibur.PuzzleLogic
{
    public class FaceColor
    {
        public string Name { get; private set; }
        public char Symbol { get; private set; }
        public Color Color { get; private set; }

        public FaceColor(Color color, string name)
        {
            Color = color;
            Name = name;
            Symbol = char.Parse(name.Substring(0, 1));
        }
    }
}
