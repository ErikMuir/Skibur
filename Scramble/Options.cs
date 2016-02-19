using CommandLine;
using CommandLine.Text;

namespace Scramble
{
    class Options
    {
        [Option(
            't', 
            "turn-count", 
            Required = false, 
            DefaultValue = 20,
            HelpText = "The number of turns for each scramble.")]
        public int TurnCount { get; set; }

        [Option(
            's', 
            "scramble-only", 
            Required = false, 
            DefaultValue = false,
            HelpText = "Returns a random scramble and then exits.")]
        public bool ScrambleOnly { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
