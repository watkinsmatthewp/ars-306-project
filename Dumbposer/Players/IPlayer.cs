using Dumbposer.Entities;

namespace Dumbposer.Players
{
    public interface IPlayer
    {
        void Play(Melody melody, MelodyContext context);
    }
}
