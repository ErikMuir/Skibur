using System.Collections.Generic;
using System.Drawing;

namespace Skibur.PuzzleLogic
{
    public partial class Cube
    {
        private static readonly FaceColor NoColor = new FaceColor(new Color(), "??");
        private static readonly FaceColor White = new FaceColor(Color.FloralWhite, "White");
        private static readonly FaceColor Yellow = new FaceColor(Color.Yellow, "Yellow");
        private static readonly FaceColor Red = new FaceColor(Color.Red, "Red");
        private static readonly FaceColor Orange = new FaceColor(Color.DarkOrange, "Orange");
        private static readonly FaceColor Blue = new FaceColor(Color.DodgerBlue, "Blue");
        private static readonly FaceColor Green = new FaceColor(Color.Green, "Green");
        public readonly List<FaceColor> FaceColors = new List<FaceColor> { NoColor, White, Yellow, Red, Orange, Blue, Green };

        private static readonly Slice NoSlice = new Slice('?', Axis.None, 1);
        private static readonly Slice Horizontal = new Slice('H', Axis.X, 1);
        private static readonly Slice Vertical = new Slice('V', Axis.Y, 1);
        private static readonly Slice Middle = new Slice('M', Axis.Z, 1);

        public static readonly Slice Left = new Slice('L', Axis.X, 0);
        public static readonly Slice Right = new Slice('R', Axis.X, 2);
        public static readonly Slice Up = new Slice('U', Axis.Y, 0);
        public static readonly Slice Down = new Slice('D', Axis.Y, 2);
        public static readonly Slice Front = new Slice('F', Axis.Z, 0);
        public static readonly Slice Back = new Slice('B', Axis.Z, 2);

        private static readonly List<Slice> XSlices = new List<Slice> { Left, Vertical, Right };
        private static readonly List<Slice> YSlices = new List<Slice> { Up, Horizontal, Down };
        private static readonly List<Slice> ZSlices = new List<Slice> { Front, Middle, Back };
        private static readonly List<Slice> TurningSlices = new List<Slice> { Left, Right, Up, Down, Front, Back };

        public static readonly TurnType NoTurn = new TurnType("NoTurn", "?", 0);
        public static readonly TurnType Clockwise = new TurnType("Clockwise", "", 1);
        public static readonly TurnType Double = new TurnType("Double", "2", 2);
        public static readonly TurnType CounterClockwise = new TurnType("CounterClockwise", "'", 3);
        public static readonly List<TurnType> TurnTypes = new List<TurnType> { Clockwise, Double, CounterClockwise };
    }
}
