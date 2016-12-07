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
            Console.Clear();
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

            header += " █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\n";
            header += " █        Scramble v0.1         █\n";
            header += " █                              █\n";
            header += " █   A Rubik's Cube Scrambler   █\n";
            header += " █                              █\n";
            header += " █   Copyright 2016 Erik Muir   █\n";
            header += " █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█\n";
            header += "\n";
            header += "   <Enter> : scramble\n";
            header += "   <Space> : start/stop timer\n";
            header += "   <Esc>   : exit\n";
            header += "\n";
            header += "  ";

            return header;
        }
    }
}
