using System;

namespace Scramble
{
    class Program
    {
        static void Main(string[] args)
        {
            var faces = new[] {"U", "D", "L", "R", "F", "B"};
            var directions = new[] {"", "'", "2"};
            var rnd = new Random();
            int turnCount;
            var scramble = "";
            var previousFace = -1;

            Console.Write(Header());
            Console.Write("   How many turns [20] ? ");

            var turnCountStr = Console.ReadLine();
            if (!int.TryParse(turnCountStr, out turnCount))
                turnCount = 20;

            scramble += "\n   ";
            for (var i = 0; i < turnCount; i++)
            {
                int face;
                do
                {
                    face = rnd.Next(faces.Length);
                } while (face == previousFace);
                
                var direction = rnd.Next(directions.Length);
                scramble += string.Format("{0}{1} ", faces[face], directions[direction]);
                previousFace = face;
            }
            scramble += "\n\n   press any key to exit...";

            Console.Write(scramble);
            Console.ReadKey();
        }

        private static string Header()
        {
            int i;
            var header = "";

            const char horizontal = '_';
            const char vertical = '|';
            const char space = ' ';
            const char newLine = '\n';

            // Line 1
            header += space;
            header += space;
            header += space;
            for (i = 0; i < 74; i++)
                header += horizontal;
            header += space;
            header += newLine;

            // Line 2
            header += space;
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
            header += space;
            header += vertical;
            for (i = 0; i < 74; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 4
            header += space;
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
            header += space;
            header += vertical;
            for (i = 0; i < 74; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 6
            header += space;
            header += space;
            header += vertical;
            for (i = 0; i < 25; i++)
                header += space;
            header += "Copyright 2015 Erik Muir";
            for (i = 0; i < 25; i++)
                header += space;
            header += vertical;
            header += newLine;

            // Line 7
            header += space;
            header += space;
            header += vertical;
            for (i = 0; i < 74; i++)
                header += horizontal;
            header += vertical;
            header += newLine;
            header += newLine;
            header += newLine;

            return header;
        }
    }
}
