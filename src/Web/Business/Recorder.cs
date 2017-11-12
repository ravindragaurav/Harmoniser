using System;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using CSCore.Codecs.WAV;

namespace Web.Business
{
    public class Recorder
    {
        private WasapiCapture _wasapiCapture;

        public Recorder()
        {
            _wasapiCapture = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
        }

        public void start()
        {
            using (_wasapiCapture)
            {
                _wasapiCapture.Initialize();
                var wasapiCaptureSource = new SoundInSource(_wasapiCapture);
                using (var stereoSource = wasapiCaptureSource.ToStereo())
                {
                    using (var writer = new WaveWriter(@"C:\Code\Harmoniser\src\Web\Business\output.wav", stereoSource.WaveFormat))
                    {
                        byte[] buffer = new byte[stereoSource.WaveFormat.BytesPerSecond];
                        wasapiCaptureSource.DataAvailable += (s, e) =>
                        {
                            int read = stereoSource.Read(buffer, 0, buffer.Length);
                            writer.Write(buffer, 0, read);
                        };
                        Console.WriteLine("Starting Record...");
                        _wasapiCapture.Start();
                        Console.ReadKey();
                        Console.WriteLine("Stopping...");
                        _wasapiCapture.Stop();
                    }
                }
            }
        }

        public void stop()
        {
            
        }
    }
}
