using Dumbposer.Entities;

namespace Dumbposer.Players
{
    public interface IPlayer
    {
        void Play(MelodyContext context, Melody melody);
    }
}
