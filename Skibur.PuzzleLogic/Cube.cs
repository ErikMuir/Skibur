using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Skibur.PuzzleLogic
{
    public class Cube
    {
        #region -- Static Members --

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

        #endregion

        #region -- Public Members --

        public List<Cubie> Cubies { get; set; }
        public int TurnCount { get; set; }
        public int ElapsedTime { get; set; }
        public FaceColor[] XColors { get; set; }
        public FaceColor[] YColors { get; set; }
        public FaceColor[] ZColors { get; set; }

        #endregion

        #region -- Constructors --

        public Cube()
        {
            Cubies = new List<Cubie>();
            TurnCount = 0;
            ElapsedTime = 0;
            XColors = new[] { Blue, NoColor, Green };
            YColors = new[] { White, NoColor, Yellow };
            ZColors = new[] { Orange, NoColor, Red };

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    for (var z = 0; z < 3; z++)
                    {
                        CubieType type;

                        if (x == 1 && y == 1 && z == 1)
                            type = CubieType.None;
                        else if (x != 1 && y != 1 && z != 1)
                            type = CubieType.Corner;
                        else if ((x + y + z) % 2 == 0)
                            type = CubieType.Center;
                        else
                            type = CubieType.Edge;

                        var xSlice = XSlices.FirstOrDefault(s => s.Index == x);
                        var ySlice = YSlices.FirstOrDefault(s => s.Index == y);
                        var zSlice = ZSlices.FirstOrDefault(s => s.Index == z);

                        var xColor = XColors[x];
                        var yColor = YColors[y];
                        var zColor = ZColors[z];

                        Cubies.Add(new Cubie(type, xSlice, ySlice, zSlice, xColor, yColor, zColor));
                    }
                }
            }
        }

        public Cube(Cube previousCube)
        {
            Cubies = previousCube.Cubies;
            TurnCount = previousCube.TurnCount;
            ElapsedTime = previousCube.ElapsedTime;
            XColors = previousCube.XColors;
            YColors = previousCube.YColors;
            ZColors = previousCube.ZColors;
        }

        #endregion

        #region -- Public Methods --

        public void Reset()
        {
            foreach (var c in Cubies)
            {
                c.XColor = XColors[c.XSlice.Index];
                c.YColor = YColors[c.YSlice.Index];
                c.ZColor = ZColors[c.ZSlice.Index];
            }

            TurnCount = 0;
            ElapsedTime = 0;
        }

        public Color GetColor(int x, int y, int z, Axis axis)
        {
            var color = NoColor;
            var cubie =
                Cubies.FirstOrDefault(c => c.XSlice == XSlices[x] && c.YSlice == YSlices[y] && c.ZSlice == ZSlices[z]);

            if (cubie == null)
                return new Color();

            switch (axis)
            {
                case Axis.X:
                    color = cubie.XColor;
                    break;
                case Axis.Y:
                    color = cubie.YColor;
                    break;
                case Axis.Z:
                    color = cubie.ZColor;
                    break;
            }

            return color.Color;
        }

        public bool IsSolved()
        {
            return
                Cubies.All(
                    c =>
                        c.XColor == XColors[c.XSlice.Index] &&
                        c.YColor == YColors[c.YSlice.Index] &&
                        c.ZColor == ZColors[c.ZSlice.Index]);
        }

        public string Scramble(int turnCount = 20)
        {
            var rnd = new Random();
            var previousSlice = NoSlice;
            var scramble = "";

            for (var i = 0; i < turnCount; i++)
            {
                Slice turningSlice;
                do
                {
                    var turningSliceIndex = rnd.Next(TurningSlices.Count);
                    turningSlice = TurningSlices[turningSliceIndex];
                } while (turningSlice == previousSlice);

                var turnType = TurnTypes[(rnd.Next(TurnTypes.Count))];

                Turn(turningSlice, turnType);

                scramble += $"{turningSlice.Symbol}{turnType.Symbol}  ";

                previousSlice = turningSlice;
            }

            TurnCount = 0;

            return scramble;
        }

        public void Turn(Slice slice, TurnType turnType)
        {
            List<Cubie> theSlice;
            Slice xSlice;
            Slice ySlice;
            Slice zSlice;
            FaceColor xColor;
            FaceColor yColor;
            FaceColor zColor;

            switch (slice.Axis)
            {
                case Axis.X:
                    theSlice = Cubies.Where(c => c.XSlice == slice).ToList();
                    for (var i = 0; i < turnType.TurnCount; i++)
                    {
                        foreach (var c in theSlice.Where(c => c.CubieType == CubieType.Corner))
                        {
                            ySlice =
                                ((slice.Index == 0 && c.YSlice.Index == c.ZSlice.Index)
                                 || (slice.Index == 2 && c.YSlice.Index != c.ZSlice.Index))
                                    ? YSlices[((c.YSlice.Index * -1) + 2)]
                                    : c.YSlice;
                            zSlice =
                                ((slice.Index == 0 && c.YSlice.Index == c.ZSlice.Index)
                                 || (slice.Index == 2 && c.YSlice.Index != c.ZSlice.Index))
                                    ? c.ZSlice
                                    : ZSlices[((c.ZSlice.Index * -1) + 2)];
                            yColor = c.ZColor;
                            zColor = c.YColor;
                            c.YSlice = ySlice;
                            c.ZSlice = zSlice;
                            c.YColor = yColor;
                            c.ZColor = zColor;
                        }
                        foreach (var c in theSlice.Where(c => c.CubieType == CubieType.Edge))
                        {
                            ySlice =
                                slice.Index == 0
                                ? YSlices[((c.ZSlice.Index * -1) + 2)]
                                : YSlices[c.ZSlice.Index];
                            zSlice =
                                slice.Index == 0
                                ? ZSlices[c.YSlice.Index]
                                : ZSlices[((c.YSlice.Index * -1) + 2)];
                            yColor = c.ZColor;
                            zColor = c.YColor;
                            c.YSlice = ySlice;
                            c.ZSlice = zSlice;
                            c.YColor = yColor;
                            c.ZColor = zColor;
                        }
                    }
                    break;
                case Axis.Y:
                    theSlice = Cubies.Where(c => c.YSlice == slice).ToList();
                    for (var i = 0; i < turnType.TurnCount; i++)
                    {
                        foreach (var c in theSlice.Where(c => c.CubieType == CubieType.Corner))
                        {
                            xSlice =
                                ((slice.Index == 0 && c.XSlice.Index == c.ZSlice.Index) ||
                                 (slice.Index == 2 && c.XSlice.Index != c.ZSlice.Index))
                                    ? c.XSlice
                                    : XSlices[((c.XSlice.Index * -1) + 2)];
                            zSlice =
                                ((slice.Index == 0 && c.XSlice.Index == c.ZSlice.Index)
                                 || (slice.Index == 2 && c.XSlice.Index != c.ZSlice.Index))
                                    ? ZSlices[((c.ZSlice.Index * -1) + 2)]
                                    : c.ZSlice;
                            xColor = c.ZColor;
                            zColor = c.XColor;
                            c.XSlice = xSlice;
                            c.ZSlice = zSlice;
                            c.XColor = xColor;
                            c.ZColor = zColor;
                        }
                        foreach (var c in theSlice.Where(c => c.CubieType == CubieType.Edge))
                        {
                            xSlice =
                                slice.Index == 0
                                ? XSlices[c.ZSlice.Index]
                                : XSlices[((c.ZSlice.Index * -1) + 2)];
                            zSlice =
                                slice.Index == 0
                                ? ZSlices[((c.XSlice.Index * -1) + 2)]
                                : ZSlices[c.XSlice.Index];
                            xColor = c.ZColor;
                            zColor = c.XColor;
                            c.XSlice = xSlice;
                            c.ZSlice = zSlice;
                            c.XColor = xColor;
                            c.ZColor = zColor;
                        }
                    }
                    break;
                case Axis.Z:
                    theSlice = Cubies.Where(c => c.ZSlice == slice).ToList();
                    for (var i = 0; i < turnType.TurnCount; i++)
                    {
                        foreach (var c in theSlice.Where(c => c.CubieType == CubieType.Corner))
                        {
                            xSlice =
                                ((slice.Index == 0 && c.XSlice.Index == c.YSlice.Index)
                                 || (slice.Index == 2 && c.XSlice.Index != c.YSlice.Index))
                                    ? XSlices[((c.XSlice.Index * -1) + 2)]
                                    : c.XSlice;
                            ySlice =
                                ((slice.Index == 0 && c.XSlice.Index == c.YSlice.Index)
                                 || (slice.Index == 2 && c.XSlice.Index != c.YSlice.Index))
                                    ? c.YSlice
                                    : YSlices[((c.YSlice.Index * -1) + 2)];
                            xColor = c.YColor;
                            yColor = c.XColor;
                            c.XSlice = xSlice;
                            c.YSlice = ySlice;
                            c.XColor = xColor;
                            c.YColor = yColor;
                        }
                        foreach (var c in theSlice.Where(c => c.CubieType == CubieType.Edge))
                        {
                            xSlice =
                                slice.Index == 0
                                ? XSlices[((c.YSlice.Index * -1) + 2)]
                                : XSlices[c.YSlice.Index];
                            ySlice =
                                slice.Index == 0
                                ? YSlices[c.XSlice.Index]
                                : YSlices[((c.XSlice.Index * -1) + 2)];
                            xColor = c.YColor;
                            yColor = c.XColor;
                            c.XSlice = xSlice;
                            c.YSlice = ySlice;
                            c.XColor = xColor;
                            c.YColor = yColor;
                        }
                    }
                    break;
            }

            TurnCount++;
        }

        public void Rotate(Axis axis, TurnType turnType)
        {
            Slice xSlice;
            Slice ySlice;
            Slice zSlice;
            FaceColor xColor;
            FaceColor yColor;
            FaceColor zColor;

            switch (axis)
            {
                case Axis.X:
                    for (var i = 0; i < turnType.TurnCount; i++)
                    {
                        foreach (var c in Cubies)
                        {
                            ySlice = YSlices[c.ZSlice.Index];
                            zSlice = ZSlices[((c.YSlice.Index * -1) + 2)];
                            yColor = c.ZColor;
                            zColor = c.YColor;
                            c.YSlice = ySlice;
                            c.ZSlice = zSlice;
                            c.YColor = yColor;
                            c.ZColor = zColor;
                        }
                    }
                    break;
                case Axis.Y:
                    for (var i = 0; i < turnType.TurnCount; i++)
                    {
                        foreach (var c in Cubies)
                        {
                            xSlice = XSlices[c.ZSlice.Index];
                            zSlice = ZSlices[((c.XSlice.Index * -1) + 2)];
                            xColor = c.ZColor;
                            zColor = c.XColor;
                            c.XSlice = xSlice;
                            c.ZSlice = zSlice;
                            c.XColor = xColor;
                            c.ZColor = zColor;
                        }
                    }
                    break;
                case Axis.Z:
                    for (var i = 0; i < turnType.TurnCount; i++)
                    {
                        foreach (var c in Cubies)
                        {
                            xSlice = XSlices[((c.YSlice.Index * -1) + 2)];
                            ySlice = YSlices[c.XSlice.Index];
                            xColor = c.YColor;
                            yColor = c.XColor;
                            c.XSlice = xSlice;
                            c.YSlice = ySlice;
                            c.XColor = xColor;
                            c.YColor = yColor;
                        }
                    }
                    break;
            }

            XColors[0] =
                Cubies.Where(c => c.XSlice.Index == 0 && c.YSlice.Index == 1 && c.ZSlice.Index == 1)
                    .Select(c => c.XColor)
                    .FirstOrDefault();
            XColors[2] =
                Cubies.Where(c => c.XSlice.Index == 2 && c.YSlice.Index == 1 && c.ZSlice.Index == 1)
                    .Select(c => c.XColor)
                    .FirstOrDefault();
            YColors[0] =
                Cubies.Where(c => c.XSlice.Index == 1 && c.YSlice.Index == 0 && c.ZSlice.Index == 1)
                    .Select(c => c.YColor)
                    .FirstOrDefault();
            YColors[2] =
                Cubies.Where(c => c.XSlice.Index == 1 && c.YSlice.Index == 2 && c.ZSlice.Index == 1)
                    .Select(c => c.YColor)
                    .FirstOrDefault();
            ZColors[0] =
                Cubies.Where(c => c.XSlice.Index == 1 && c.YSlice.Index == 1 && c.ZSlice.Index == 0)
                    .Select(c => c.ZColor)
                    .FirstOrDefault();
            ZColors[2] =
                Cubies.Where(c => c.XSlice.Index == 1 && c.YSlice.Index == 1 && c.ZSlice.Index == 2)
                    .Select(c => c.ZColor)
                    .FirstOrDefault();
        }

        #endregion

        #region -- Overloaded Extension Methods --

        public new string ToString()
        {
            var cubeString = "";

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    for (var z = 0; z < 3; z++)
                    {
                        cubeString += Cubies
                            .Where(c => c.XSlice.Index == x && c.YSlice.Index == y && c.ZSlice.Index == z)
                            .Select(c => $"{c.XColor.Symbol}{c.YColor.Symbol}{c.ZColor.Symbol}")
                            .FirstOrDefault();
                    }
                }
            }

            cubeString += $"|{TurnCount}|{ElapsedTime}";

            return cubeString;
        }

        #endregion
    }
}
