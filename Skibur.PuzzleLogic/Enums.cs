using System.ComponentModel;

namespace Skibur.PuzzleLogic
{
    public static partial class Enums
    {
        public enum Axis : short
        {
            [Description("None")]
            None = -1,

            [Description("X")]
            X = 0,

            [Description("Y")]
            Y = 1,

            [Description("Z")]
            Z = 2
        };

        public enum CubieType : short
        {
            [Description("None")]
            None = 0,

            [Description("Center")]
            Center = 1,

            [Description("Edge")]
            Edge = 2,

            [Description("Corner")]
            Corner = 3
        };
    }    
}
