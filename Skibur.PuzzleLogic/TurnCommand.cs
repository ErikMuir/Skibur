using System;

namespace Skibur.PuzzleLogic
{
    public class TurnCommand : Command
    {
        private Cube Cube;
        private Slice Slice;
        private TurnType TurnType;

        private static readonly TurnType NoTurn = new TurnType("NoTurn", "?", 0);
        private static readonly TurnType Clockwise = new TurnType("Clockwise", "", 1);
        private static readonly TurnType Double = new TurnType("Double", "2", 2);
        private static readonly TurnType CounterClockwise = new TurnType("CounterClockwise", "'", 3);

        public TurnCommand(Cube cube, Slice slice, TurnType turnType)
        {
            this.Cube = cube;
            this.Slice = slice;
            this.TurnType = turnType;
        }

        // Execute new command
        public override void Execute()
        {
            Cube.Turn(Slice, TurnType);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            Cube.Turn(Slice, Undo(TurnType));
        }

        // Returns opposite operator for given operator
        private TurnType Undo(TurnType turnType)
        {
            switch (turnType.TurnCount)
            {
                case 0: return NoTurn;
                case 1: return CounterClockwise;
                case 2: return Double;
                case 3: return Clockwise;
                default: throw new Exception("turnType");
            }
        }
    }
}
