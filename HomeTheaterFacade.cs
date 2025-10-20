namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
            private Amplifier amplifier;
            private Tuner tuner;
            private DvdPlayer dvdPlayer;
            private CdPlayer cdPlayer;
            private Projector projector;
            private TheaterLights theaterLights;
            private Screen screen;
            private PopcornPopper popcornPopper;

            // Constructor receives all subsystem instances
            public HomeTheaterFacade(
                Amplifier amplifier,
                Tuner tuner,
                DvdPlayer dvdPlayer,
                CdPlayer cdPlayer,
                Projector projector,
                TheaterLights theaterLights,
                Screen screen,
                PopcornPopper popcornPopper)
            {
                this.amplifier = amplifier;
                this.tuner = tuner;
                this.dvdPlayer = dvdPlayer;
                this.cdPlayer = cdPlayer;
                this.projector = projector;
                this.theaterLights = theaterLights;
                this.screen = screen;
                this.popcornPopper = popcornPopper;
            }

            // method for watching a movie
            public void WatchMovie(string movie)
            {
                Console.WriteLine("Get ready to watch a movie");
                popcornPopper.On();
                popcornPopper.Pop();
                theaterLights.Dim(10);
                screen.Up();
                projector.On();
                projector.WideScreenMode();
                amplifier.On();
                amplifier.SetDvd(dvdPlayer);
                amplifier.SetSurroundSound();
                amplifier.SetVolume(5);
                dvdPlayer.On();
                dvdPlayer.Play(movie);
            }

            // High-level method to end a movie
            public void EndMovie()
            {
                Console.WriteLine("Shutting movie theater down...");
                popcornPopper.Off();
                theaterLights.On();
                screen.Down();
                projector.Off();
                amplifier.Off();
                dvdPlayer.Stop();
                dvdPlayer.Eject();
                dvdPlayer.Off();
            }
        }
}