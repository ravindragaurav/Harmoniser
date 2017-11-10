using System;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;
using CSCore.Codecs.WAV;

namespace Recorder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            start();
        }

        private static void start()
        {
            using (var wasapiCapture = new WasapiCapture(true, AudioClientShareMode.Shared, 30))
            {
                wasapiCapture.Initialize();
                var wasapiCaptureSource = new SoundInSource(wasapiCapture);
                using (var stereoSource = wasapiCaptureSource.ToStereo())
                {
                    //using (var writer = MediaFoundationEncoder.CreateWMAEncoder(stereoSource.WaveFormat, "output.wma"))
                    using (var writer = new WaveWriter(@"C:\Code\Harmoniser\src\Recorder\output.wav", stereoSource.WaveFormat))
                    {
                        byte[] buffer = new byte[stereoSource.WaveFormat.BytesPerSecond];
                        wasapiCaptureSource.DataAvailable += (s, e) =>
                        {
                            int read = stereoSource.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, read);
                        };
                        Console.WriteLine("Starting Record...");
                        wasapiCapture.Start();

                        Console.ReadKey();
                        Console.WriteLine("Stopping...");
                        wasapiCapture.Stop();
                    }
                }
            }
        }
    }
}
