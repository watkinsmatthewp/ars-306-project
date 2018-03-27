using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Dumbposer.Tests
{
    public class NoteTests
    {
        [Fact]
        public void NoteTest()
        {
            var note = new Note { ID = 50 };
            Assert.Equal("B4", note.Name);
            note.ID++;
            Assert.Equal("C5", note.Name);
        }
    }
}
