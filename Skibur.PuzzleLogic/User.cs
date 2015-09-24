using System.Collections.Generic;

namespace Skibur.PuzzleLogic
{
    public class User
    {
        public Cube Cube { get; set; }
        public List<Command> Commands { get; set; }
        public int Current { get; set; }

        public User()
        {
            Cube = new Cube();
            Commands = new List<Command>();
            Current = 0;
        }

        public void Redo(int levels = 1)
        {
            for (int i = 0; i < levels; i++)
            {
                if (Current < Commands.Count)
                {
                    Command command = Commands[Current++] as Command;
                    command.Execute();
                }
            }
        }

        public void Undo(int levels = 1)
        {
            for (int i = 0; i < levels; i++)
            {
                if (Current > 0)
                {
                    Command command = Commands[--Current] as Command;
                    command.UnExecute();
                }
            }
        }

        public void Turn(Slice slice, TurnType turnType)
        {
            // create and execute a new command
            Command command = new TurnCommand(Cube, slice, turnType);
            command.Execute();

            // remove the ability to redo now that we've triggered a new command
            Commands.RemoveRange(Current, Commands.Count - Current);

            // add the new command to the stack
            Commands.Add(command);
            Current++;
        }

        public void Rotate(Axis axis, TurnType turnType)
        {
            // create and execute a new command
            Command command = new RotateCommand(Cube, axis, turnType);
            command.Execute();

            // remove the ability to redo now that we've triggered a new command
            Commands.RemoveRange(Current, Commands.Count - Current);
            
            // add the new command to the stack
            Commands.Add(command);
            Current++;
        }

        public void Reset()
        {
            Cube.Reset();
            Commands = new List<Command>();
            Current = 0;
        }
    }
}
