using System;

namespace Dumbposer
{
    public class Tone
    {
        readonly static string[][] TONE_NAMES = new string[][]
        {
            new [] { "C" },
            new [] { "C#", "Db" },
            new [] { "D" },
            new [] { "D#", "Eb" },
            new [] { "E" },
            new [] { "F" },
            new [] { "F#", "Gb" },
            new [] { "G" },
            new [] { "G#", "Ab" },
            new [] { "A" },
            new [] { "A#", "Bb" },
            new [] { "B" }
        };

        public int Octave { get; set; }
        public int Number { get; set; }

        public string Name
        {
            get => TONE_NAMES[Number][0];
            set => Number = GetToneNumberFromName(value);
        }

        public int ID
        {
            get => (Octave * 12) + Number - 8;
            set
            {
                var relativeID = value - 8;
                Octave = relativeID / 12;
                Number = relativeID % 12;
            }
        }

        public string FullName
        {
            get => $"{Name}{Octave}";
            set
            {
                Name = value.Substring(0, value.Length - 1);
                Octave = value[value.Length - 1];
            }
        }

        #region Private helpers

        int GetToneNumberFromName(string value)
        {
            for (var i = 0; i < TONE_NAMES.Length; i++)
            {
                var toneNames = TONE_NAMES[i];
                for (var j = 0; j < toneNames.Length; j++)
                {
                    if (toneNames[j] == value)
                    {
                        return i;
                    }
                }
            }
            throw new Exception($"Tone not found: {value}");
        }

        #endregion
    }
}
