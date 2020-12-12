using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterGoodson
{
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; } //in minutes

        public List<string> Scenes { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Category: {this.Category}");
            Console.WriteLine($"RunTime: {this.RunTime}");
        }

        public void PrintScenes()
        {
            int index = 0;

            foreach(string scene in Scenes)
            {
                Console.WriteLine($"{index}: {scene}");
                index += 1;
            }
        }

        public abstract void Play();
    }
}
