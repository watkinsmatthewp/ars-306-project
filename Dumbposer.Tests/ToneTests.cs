using Xunit;

namespace Dumbposer.Tests
{
    public class ToneTests
    {
        private static readonly Tone HOME_TONE = new Tone
        {
            Octave = 4,
            Number = 9
        };

        private static readonly Tone FSHARP3 = new Tone
        {
            Octave = 3,
            Number = 6
        };

        #region Home Tone

        [Fact]
        public void Tone_HomeTone_StoredFields_Test()
        {
            Assert.Equal(4, HOME_TONE.Octave);
            Assert.Equal(9, HOME_TONE.Number);
        }

        [Fact]
        public void Tone_HomeTone_CalculatedFields_ID_Test()
        {
            Assert.Equal(49, HOME_TONE.ID);
        }

        [Fact]
        public void Tone_HomeTone_CalculatedFields_Name_Test()
        {
            Assert.Equal("A", HOME_TONE.Name);
        }

        [Fact]
        public void Tone_HomeTone_CalculatedFields_FullName_Test()
        {
            Assert.Equal("A4", HOME_TONE.FullName);
        }

        #endregion

        #region F#3

        [Fact]
        public void Tone_FSharp3_StoredFields_Test()
        {
            Assert.Equal(3, FSHARP3.Octave);
            Assert.Equal(6, FSHARP3.Number);
        }

        [Fact]
        public void Tone_FSharp3_CalculatedFields_ID_Test()
        {
            Assert.Equal(34, FSHARP3.ID);
        }

        [Fact]
        public void Tone_FSharp3_CalculatedFields_Name_Test()
        {
            Assert.Equal("F#", FSHARP3.Name);
        }

        [Fact]
        public void Tone_FSharp3_CalculatedFields_FullName_Test()
        {
            Assert.Equal("F#3", FSHARP3.FullName);
        }
        #endregion
    }
}
