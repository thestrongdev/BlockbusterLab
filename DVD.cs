using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterGoodson
{
    class DVD : Movie
    {
        public override void Play()
        {

            do
            {
                Console.WriteLine("What scene would you like to watch? Choose a number from 0 to 2");

                PrintScenes();

                string userScene = Console.ReadLine();

                bool isInt = int.TryParse(userScene, out int sceneNum);

                if (isInt && sceneNum >= 0 && sceneNum < Scenes.Count)
                {
                    Console.WriteLine(Scenes[sceneNum]);

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number from the list");
                }

            } while (true);

        }

        public override void PlayWholeMovie()
        {
            foreach(string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }
    }
}
