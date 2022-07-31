using System;
using System.Collections.Generic;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };

                var group2 = new Group()
                {
                    Name = "Linkin Park"

                };

                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song() { Name = "In the end", Groupid = group2.Id },
                    new Song() { Name = "Numb", Groupid = group2.Id},
                    new Song() { Name = "Mutter", Groupid = group.Id}
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, Group name: {song.Group.Name}");
                }
                
                Console.ReadLine();
            }
        }
    }
}
