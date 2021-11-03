using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class PlaySound
    {
        static private SoundPlayer simpleSound;

        static public void Play(string path)
        {
            simpleSound = new SoundPlayer(path);
            simpleSound.Play();
        }

        static public void Stop()
        {
            if (simpleSound != null)
                simpleSound.Stop();
        }
    }
}
