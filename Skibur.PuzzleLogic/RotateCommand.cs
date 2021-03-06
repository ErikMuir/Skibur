using System;

namespace Skibur.PuzzleLogic
{
    public class RotateCommand : Command
    {
        private Cube Cube;
        private Axis Axis;
        private TurnType TurnType;

        private static readonly TurnType NoTurn = new TurnType("NoTurn", "?", 0);
        private static readonly TurnType Clockwise = new TurnType("Clockwise", "", 1);
        private static readonly TurnType Double = new TurnType("Double", "2", 2);
        private static readonly TurnType CounterClockwise = new TurnType("CounterClockwise", "'", 3);

        public RotateCommand(Cube cube, Axis axis, TurnType turnType)
        {
            Cube = cube;
            Axis = axis;
            TurnType = turnType;
        }

        // Execute new command
        public override void Execute()
        {
            Cube.Rotate(Axis, TurnType);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            Cube.Rotate(Axis, Undo(TurnType));
        }

        // Returns opposite TurnType for given TurnType
        private TurnType Undo(TurnType turnType)
        {
            switch (turnType.TurnCount)
            {
                case 0: return NoTurn;
                case 1: return CounterClockwise;
                case 2: return Double;
                case 3: return Clockwise;
                default: throw new Exception("TurnType");
            }
        }
    }
}
