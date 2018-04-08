namespace Dumbposer.Entities
{
    public static class Scale
    {
        public static readonly int[] Major = new[]
        {
            Interval.P1,
            Interval.M2,
            Interval.M3,
            Interval.P4,
            Interval.P5,
            Interval.M6,
            Interval.M7,
            Interval.P8
        };

        public static readonly int[] NaturalMinor = new[]
        {
            Interval.P1,
            Interval.M2,
            Interval.m3,
            Interval.P4,
            Interval.P5,
            Interval.m6,
            Interval.m7,
            Interval.P8
        };

        public static readonly int[] HarmonicMinor = new[]
        {
            Interval.P1,
            Interval.M2,
            Interval.m3,
            Interval.P4,
            Interval.P5,
            Interval.m6,
            Interval.M7,
            Interval.P8
        };

        public static readonly int[] MelodicMinorScale = new[]
        {
            Interval.P1,
            Interval.M2,
            Interval.m3,
            Interval.P4,
            Interval.P5,
            Interval.M6,
            Interval.M7,
            Interval.P8
        };
    }
}
