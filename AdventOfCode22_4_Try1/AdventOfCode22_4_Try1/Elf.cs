using static System.Int32;

namespace AdventOfCode22_4_Try1;

    internal class Elf
    {
        public Range AssignmentRange { get; }

        public Elf(string assignment)
        {
            TryParse(assignment.Split('-')[0], out var start);
            TryParse(assignment.Split('-')[1], out var end);

            AssignmentRange = new Range(new Index(start), new Index(end));
        }
    }