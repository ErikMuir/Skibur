using System;
using System.Timers;
using CommandLine;

namespace Skibur.Scramble
{
    internal class Program
    {
        private static TimeSpan _timeSpan;
        private static readonly Timer Timer = new Timer();
        private static readonly Random Random = new Random();
        private static readonly Options Options = new Options();
        private static readonly Parser Parser = new Parser();

        private static void Main(string[] args)
        {
            if (Parser.ParseArguments(args, Options))
            {
                if (Options.ScrambleOnly)
                {
                    Console.Write(Scramble());
                    Environment.Exit(0);
                }
            }                    

            Timer.Elapsed += ShowTimer;
            Timer.Interval = 1000;
            Timer.Enabled = false;

            Console.CursorVisible = false;

            Console.Write(Header());

            var isRunning = true;

            while (isRunning)
            {
                var input = Console.ReadKey(true);

                switch (input.Key)
                {
                    case ConsoleKey.Enter:
                        if (!Timer.Enabled) 
                            Console.Write(Scramble());
                        break;
                    case ConsoleKey.Spacebar:
                        _timeSpan = TimeSpan.Zero;
                        Timer.Enabled = !Timer.Enabled;
                        Console.Write(!Timer.Enabled ? "\n\n  " : $"\r  {_timeSpan.ToString(@"mm\:ss")}");
                        break;
                    case ConsoleKey.Escape:
                        isRunning = false;
                        break;
                }
            }

            Environment.Exit(0);
        }

        private static void ShowTimer(object source, ElapsedEventArgs e)
        {
            _timeSpan += TimeSpan.FromSeconds(1);
            Console.Write($"\r  {_timeSpan.ToString(@"mm\:ss")}");
        }

        private static string Scramble()
        {
            var previousFace = -1;
            var faces = new[] {'U', 'D', 'L', 'R', 'F', 'B'};
            var directions = new[] { char.MinValue, '\'', '2' };
            var scramble = "";

            for (var i = 0; i < Options.TurnCount; i++)
            {
                int face;
                do
                {
                    face = Random.Next(faces.Length);
                } while (face == previousFace);

                var direction = Random.Next(directions.Length);
                scramble += $"{faces[face]}{directions[direction]} ";
                previousFace = face;
            }

            scramble += "\n\n  ";

            return scramble;
        }

        private static string Header()
        {
            var header = "";
            int i;

            const char horizontal = '_';
            const char vertical = '|';
            const char space = ' ';
            const char newLine = '\n';

            // Line 1
            header += space;
            header += space;
            for (i = 0; i < 74; i++)
                header += horizontal;
            header += space;
            header += newLine;

            // Line 2
            header += space;
            header += vertical;
            for (i = 0; i < 30; i++)
                header += space;
            header += "Scramble v0.1";
            for (i = 0; i < 31; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 3
            header += space;
            header += vertical;
            for (i = 0; i < 74; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 4
            header += space;
            header += vertical;
            for (i = 0; i < 25; i++)
                header += space;
            header += "A Rubik's Cube Scrambler";
            for (i = 0; i < 25; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 5
            header += space;
            header += vertical;
            for (i = 0; i < 74; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 6
            header += space;
            header += vertical;
            for (i = 0; i < 25; i++)
                header += space;
            header += $"Copyright {DateTime.Today.Year} Erik Muir";
            for (i = 0; i < 25; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 7
            header += space;
            header += vertical;
            for (i = 0; i < 74; i++)
                header += horizontal;
            header += vertical;
            header += newLine;

            // Instructions
            header += newLine;
            header += newLine;
            header += "  <Enter> : scramble";
            header += newLine;
            header += "  <Space> : start/stop timer";
            header += newLine;
            header += "  <Esc>   : exit";
            header += newLine;
            header += newLine;
            header += "  ";

            return header;
        }
    }
}
