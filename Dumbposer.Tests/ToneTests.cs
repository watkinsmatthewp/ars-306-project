using Xunit;

namespace Dumbposer.Tests
{
    public class ToneTests
    {
        private Tone HOME_TONE = new Tone
        {
            Octave = 4,
            Number = 9
        };

        [Fact]
        public void Tone_HappyPath_StoredFields_Test()
        {
            Assert.Equal(4, HOME_TONE.Octave);
            Assert.Equal(9, HOME_TONE.Number);
        }

        [Fact]
        public void Tone_HappyPath_CalculatedFields_ID_Test()
        {
            Assert.Equal(49, HOME_TONE.ID);
        }

        [Fact]
        public void Tone_HappyPath_CalculatedFields_Name_Test()
        {
            Assert.Equal("A", HOME_TONE.Name);
        }

        [Fact]
        public void Tone_HappyPath_CalculatedFields_FullName_Test()
        {
            Assert.Equal("A4", HOME_TONE.FullName);
        }
    }
}
