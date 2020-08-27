using Cinema.Items;
using System;
using System.Threading;

namespace Cinema
{
    // 7 глава
    // 9 патерн
    // Фасад
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier _amp = new Amplifier();
            Tuner _tuner = new Tuner();
            DvdPlayer _dvd = new DvdPlayer();
            CdPlayer _cd = new CdPlayer();
            Progector _progector = new Progector();
            TheaterLights _lights = new TheaterLights();
            Screen _screen = new Screen();
            PopcornPopper _popper = new PopcornPopper();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(_amp, _tuner, _dvd, _cd, _progector, _lights, _screen, _popper);

            homeTheater.WatchMovie("Люди в черном");
            Console.WriteLine("\n\n\n");
            Thread.Sleep(2500);
            homeTheater.EndMovie();
        }
    }
}
