using CommandLine;

namespace Skibur.Scramble
{
    internal class Options
    {
        [Option(
            't',
            "turns",
            Required = false,
            Default = 20,
            HelpText = "The number of turns for each scramble.")]
        public int TurnCount { get; set; }

        [Option(
            's',
            "scramble",
            Required = false,
            Default = false,
            HelpText = "Returns a random scramble and then exits.")]
        public bool ScrambleOnly { get; set; }
    }
}
