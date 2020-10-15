using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    
    class Program
    {
        class Song
        {
            public string TypeList { get; set; } // създаване на обект
            public string Name { get; set; } // създаване на обект
            public string Time { get; set; } // създаване на обект
        }
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine()); // вход
            List<Song> input = new List<Song>(); // създаване на списък към клас "Song"
            for (int i = 0; i < numSongs; i++) // завъртане на input песни
            {
                string[] data = Console.ReadLine().Split('_'); // прочитане на песен
                string type = data[0]; // задаване на стойност в string "type"
                string name = data[1]; // задаване на стойност в string "name"
                string time = data[2]; // задаване на стойност в string "time"
                Song track = new Song(); // инициализиране на обект Song
                track.TypeList = type; // свързване на обект "TypeList" към string "type"
                track.Name = name; // свързване на "Name" към string "name"
                track.Time = time; // свързване на "Time" към string "time"
                input.Add(track);  // попълване на списък "input"
            }
            string typeList = Console.ReadLine(); // прочитане на изход
            if (typeList == "all")
            {
                foreach (Song track in input)
                {
                    Console.WriteLine(track.Name);
                }
            }
            else
            {
                foreach(Song track in input)
                { 
                    if (track.TypeList == typeList)
                    {
                        Console.WriteLine(track.Name);
                    }
                }
            }
        }
    }
}