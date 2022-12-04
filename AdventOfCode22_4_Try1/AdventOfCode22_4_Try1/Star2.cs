using static System.Int32;

namespace AdventOfCode22_4_Try1;

internal static class Star2
{
    public static int Run()
    {
        var assignments = File.ReadAllText("Input/input.txt");
        var pairs = assignments.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var anyOverlapps = 0;

        foreach (var pair in pairs)
        {
            var splitPair = pair.Split(',');
            var elfA = new Elf(splitPair[0]);
            var elfB = new Elf(splitPair[1]);

            if ((
                    (elfA.AssignmentRange.End.Value >= elfB.AssignmentRange.Start.Value) &&
                    (elfA.AssignmentRange.Start.Value <= elfB.AssignmentRange.Start.Value)
                ) || (
                    (elfB.AssignmentRange.End.Value >= elfA.AssignmentRange.Start.Value) &&
                    (elfB.AssignmentRange.Start.Value <= elfA.AssignmentRange.Start.Value)
                ))
            {
                anyOverlapps += 1;
            }
        }

        return anyOverlapps;
    }
}