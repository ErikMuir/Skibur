namespace Skibur.PuzzleLogic
{
    public class Cubie
    {
        public CubieType CubieType { get; set; }
        public Slice XSlice { get; set; }
        public Slice YSlice { get; set; }
        public Slice ZSlice { get; set; }
        public FaceColor XColor { get; set; }
        public FaceColor YColor { get; set; }
        public FaceColor ZColor { get; set; }

        public Cubie(
            CubieType cubieType,
            Slice xSlice,
            Slice ySlice,
            Slice zSlice,
            FaceColor xColor,
            FaceColor yColor,
            FaceColor zColor)
        {
            CubieType = cubieType;
            XSlice = xSlice;
            YSlice = ySlice;
            ZSlice = zSlice;
            XColor = xColor;
            YColor = yColor;
            ZColor = zColor;
        }
    }
}
