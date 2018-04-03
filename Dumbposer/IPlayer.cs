using System;
using System.Collections.Generic;
using System.Text;

namespace Dumbposer
{
    interface IPlayer
    {
        int BeatsPerSecond { get; set; }
        void Play(Note note);
    }
}
