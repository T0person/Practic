using Cinema.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class HomeTheaterFacade
    {
        Amplifier _amp;
        Tuner _tuner;
        DvdPlayer _dvd;
        CdPlayer _cd;
        Progector _progector;
        TheaterLights _lights;
        Screen _screen;
        PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier _amp, Tuner _tuner, DvdPlayer _dvd, CdPlayer _cd, Progector _progector, TheaterLights _lights,Screen _screen, PopcornPopper _popper)
        {
            this._amp = _amp;
            this._tuner = _tuner;
            this._dvd = _dvd;
            this._cd = _cd;
            this._progector = _progector;
            this._lights = _lights;
            this._screen = _screen;
            this._popper = _popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Готовимся смотреть фильм!");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _progector.On();
            _progector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Выключаем кинотеатр!");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _progector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}
