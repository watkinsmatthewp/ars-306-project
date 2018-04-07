using Dumbposer.Composition;
using Dumbposer.Entities;
using Dumbposer.Players;
using System;

namespace Dumbposer
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new ConsolePlayer
            {
                Debug = true,
                MakeSound = true,
            };
            var melody = new HappyBirthdayCompositionStrategy().Compose(null);
            new ConsolePlayer().Play(melody, new MelodyContext
            {
                BeatsPerMinute = 120
            });
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        //static void PlayRandomNotes(ConsolePlayer player)
        //{
        //    var random = new Random();
        //    for (var i = 0; i < 1000; i++)
        //    {
        //        var toneName = (char)random.Next('A', 'G' + 1);
        //        var octaveNumber = random.Next(2, 8);
        //        var beats = random.Next(1, 17) * .0625d;
        //        player.Play(new Note
        //        {
        //            Beats = beats,
        //            Tone = new Tone
        //            {
        //                FullName = $"{toneName}{octaveNumber}"
        //            }
        //        });
        //    }
        //}
    }
}
