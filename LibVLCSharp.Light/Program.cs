using LibVLCSharp.Shared;
using System;

namespace LibVLCSharp.Light
{
    class Program
    {
        static void Main(string[] args)
        {
            Core.Initialize();

            var libVLC = new LibVLC();
            libVLC.Log += (sender, e) => Console.WriteLine(e.Message);
            var media = new Media(libVLC, "matrix.mkv");
            var mp = new MediaPlayer(media);
            mp.Play();
            Console.ReadKey();
        }
    }
}
