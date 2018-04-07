namespace Dumbposer.Entities
{
    public class Note
    {
        public int Interval { get; set; } = int.MinValue;
        public int OctaveOffset { get; set; }
        public double Beats { get; set; }
        public bool IsRest => Interval == int.MinValue;

        public Tone GetTone(Tone homeTonic) => IsRest ? null : new Tone
        {
            ID = homeTonic.ID + (OctaveOffset * 12) + Interval
        };
    }
}
