using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     * Let's assume you have a home theater system with various components like a DVD player, a projector, 
     * and a sound system. Instead of interacting with each component individually, you can use a facade 
     * to simplify the process of watching a movie.
    */

    /*Explanation:
     * Subsystem Classes (DVDPlayer, Projector, SoundSystem):
     * These represent the complex parts of the home theater system.
     * Each subsystem has its own set of operations.
     * 
     * Facade (HomeTheaterFacade):
     * This provides a simplified interface for the client to interact with the subsystem.
     * It encapsulates the complexity of the subsystems and offers a higher-level interface.
     * 
     * Client (Program):
     * The client interacts with the subsystem through the facade, without needing to know the details of the subsystem.
    */

    // Subsystem Class 1
    public class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player is On");
        public void Play() => Console.WriteLine("DVD is Playing");
        public void Off() => Console.WriteLine("DVD Player is Off");
    }

    // Subsystem Class 2
    public class Projector
    {
        public void On() => Console.WriteLine("Projector is On");
        public void Off() => Console.WriteLine("Projector is Off");
        public void SetInput(string input) => Console.WriteLine($"Projector input set to {input}");
    }

    // Subsystem Class 3
    public class SoundSystem
    {
        public void On() => Console.WriteLine("Sound System is On");
        public void SetVolume(int level) => Console.WriteLine($"Sound System volume set to {level}");
        public void Off() => Console.WriteLine("Sound System is Off");
    }

    // Facade
    public class HomeTheaterFacade
    {
        private readonly DVDPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly SoundSystem _soundSystem;

        public HomeTheaterFacade(DVDPlayer dvdPlayer, Projector projector, SoundSystem soundSystem)
        {
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _soundSystem = soundSystem;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Getting ready to watch a movie...");
            _dvdPlayer.On();
            _dvdPlayer.Play();
            _projector.On();
            _projector.SetInput("DVD Player");
            _soundSystem.On();
            _soundSystem.SetVolume(10);
            Console.WriteLine("Movie is now playing.\n");
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the home theater...");
            _dvdPlayer.Off();
            _projector.Off();
            _soundSystem.Off();
            Console.WriteLine("Home theater is off.\n");
        }
    }
}
