using System;
using System.Collections.Generic;
using System.Timers;
using CommandLine;

namespace Skibur.Scramble
{
    internal class Program
    {
        private static TimeSpan _timeSpan;
        private static readonly Timer Timer = new Timer();
        private static readonly Random Random = new Random();

        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Run)
                .WithNotParsed(HandleParseError);
        }

        private static void Run(Options opts)
        {
            if (opts.ScrambleOnly)
            {
                Console.Write(Scramble(opts.TurnCount));
                Environment.Exit(0);
            }

            Timer.Elapsed += ShowTimer;
            Timer.Interval = 1000;
            Timer.Enabled = false;

            Console.CursorVisible = false;
            Console.Clear();
            Header().ForEach(Console.WriteLine);

            var isRunning = true;

            while (isRunning)
            {
                var input = Console.ReadKey(true);

                switch (input.Key)
                {
                    case ConsoleKey.Enter:
                        if (!Timer.Enabled)
                            Console.Write(Scramble(opts.TurnCount));
                        break;
                    case ConsoleKey.Spacebar:
                        _timeSpan = TimeSpan.Zero;
                        Timer.Enabled = !Timer.Enabled;
                        Console.Write(!Timer.Enabled ? "\n\n" : $"\r  {_timeSpan.ToString(@"mm\:ss")}");
                        break;
                    case ConsoleKey.Escape:
                        isRunning = false;
                        break;
                }
            }

            Environment.Exit(0);
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            if (errs.IsVersion())
            {
                // TODO
                Console.WriteLine("Version Request");
                return;
            }

            if (errs.IsHelp())
            {
                // TODO
                Console.WriteLine("Help Request");
                return;
            }

            // TODO
            Console.WriteLine("Parser Fail");
        }

        private static void ShowTimer(object source, ElapsedEventArgs e)
        {
            _timeSpan += TimeSpan.FromSeconds(1);
            Console.Write($"\r  {_timeSpan.ToString(@"mm\:ss")}");
        }

        private static string Scramble(int turnCount)
        {
            var previousFace = -1;
            var faces = new[] { 'U', 'D', 'L', 'R', 'F', 'B' };
            var directions = new[] { char.MinValue, '\'', '2' };
            var scramble = "  ";

            for (var i = 0; i < turnCount; i++)
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

            scramble += "\n\n";

            return scramble;
        }

        private static List<string> Header()
        {
            return new List<string>
            {
                string.Empty,
                " █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█",
                " █        Scramble v0.1         █",
                " █                              █",
                " █   A Rubik's Cube Scrambler   █",
                " █                              █",
                " █   Copyright 2016 Erik Muir   █",
                " █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
                string.Empty,
                "   <Enter> : scramble",
                "   <Space> : start/stop timer",
                "   <Esc>   : exit",
                string.Empty,
                "  ",
            };
        }
    }
}
