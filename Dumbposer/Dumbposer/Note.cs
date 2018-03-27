using System;

namespace Dumbposer
{
    public class Note
    {
        const int HALF_STEPS_IN_OCTAVE = 12;
        const int HOME_OCTAVE = 4;
        const char HOME_NOTE = 'A';
        const int HOME_ID = 49;
        const double HOME_FREQUENCY = 440;

        static readonly char[] NOTES = new char[] { 'C', 'D', 'E', 'F', 'G', 'A', 'B' };
        static readonly int HOME_NOTE_INDX = Array.IndexOf(NOTES, HOME_NOTE);
        static readonly double HALF_STEP_FREQUENCY_BASE = Math.Pow(2, 1 / 12d);

        private string _name;
        private int _id;
        public double _frequency;

        public string Name
        {
            get => _name;
            set => SetAllByName(value);
        }

        public int ID
        {
            get => _id;
            set => SetAllByID(value);
        }

        public double Frequency { get; private set; }

        #region Private helpers

        void SetAllByName(string value)
        {
            throw new NotImplementedException();
        }

        void SetAllByID(int id)
        {
            _id = id;
            _name = GetNameFromID(_id);
            Frequency = GetFrequencyFromID(_id);
        }

        double GetFrequencyFromID(int id)
            => HOME_FREQUENCY * Math.Pow(HALF_STEP_FREQUENCY_BASE, id - HOME_ID);

        string GetNameFromID(int id)
        {
            var halfStepsFromHome = id - HOME_ID;
            var octavesFromHome = halfStepsFromHome / HALF_STEPS_IN_OCTAVE;
            var halfStepsFromHomeNote = halfStepsFromHome % HALF_STEPS_IN_OCTAVE;
            var newNoteIndex = (HOME_NOTE_INDX + halfStepsFromHomeNote) % NOTES.Length;
            return $"{NOTES[newNoteIndex]}{HOME_OCTAVE + octavesFromHome}";
        }

        //int GetIdFromName(string name)
        //{
        //    var note = name[0];
        //    var octave = name[1];
        //}

        #endregion
    }
}
