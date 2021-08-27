using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songInfo = Console.ReadLine().Split('_');
                string typeList = songInfo[0];
                string name = songInfo[1];
                string time = songInfo[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string songsToPrint = Console.ReadLine();

            if (songsToPrint == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs.Where(x=>x.TypeList == songsToPrint))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
