using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Structural._5._Facade
{
    public class HomeTheaterFacade
    {
        private readonly Projector _projector;
        private readonly SoundSystem _soundSystem;
        private readonly DVDPlayer _dvdPlayer;

        public HomeTheaterFacade(Projector projector, SoundSystem soundSystem, DVDPlayer dvdPlayer)
        {
            _projector = projector;
            _soundSystem = soundSystem;
            _dvdPlayer = dvdPlayer;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Preparing to watch a movie...");

            _projector.On();
            _projector.SetInput("DVD");

            _soundSystem.On();
            _soundSystem.SetVolume(15);

            _dvdPlayer.On();
            _dvdPlayer.Play(movie);

            Console.WriteLine("Movie is starting... Enjoy!");
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the home theater system...");

            _dvdPlayer.Stop();
            _dvdPlayer.Off();

            _soundSystem.Off();

            _projector.Off();

            Console.WriteLine("Home theater shut down.");
        }
    }
}
