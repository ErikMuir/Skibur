namespace Skibur.PuzzleLogic
{
    public static partial class Enums
    {
        public enum Axis : short
        {
            None    = -1,
            X       = 0,
            Y       = 1,
            Z       = 2,
        };

        public enum CubieType : short
        {
            None    = 0,
            Center  = 1,
            Edge    = 2,
            Corner  = 3,
        };
    }    
}
