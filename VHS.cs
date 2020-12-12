using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterGoodson
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public override void Play() //plays the scene at the current time and then icnrements Current time
        {
            Console.WriteLine($"{Scenes[CurrentTime]}");

            CurrentTime += 1;
        }

        public override void PlayWholeMovie()
        {
            Rewind();
            foreach(string scene in Scenes)
            {
                Console.WriteLine(scene[CurrentTime]);
                CurrentTime += 1;
            }

        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
