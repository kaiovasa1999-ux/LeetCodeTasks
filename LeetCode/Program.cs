namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> songsQueue = new Queue<string>(data);
            var songsOut = string.Empty;
            while (songsQueue.Any())
            {

                var dataCommand = Console.ReadLine();
                var songName = dataCommand.Substring(4);
                var x = dataCommand.Split(" ");

                var command = x[0];
                
                if (command == "Play" && songsQueue.Any())
                {
                    
                    
                    songsOut += songsQueue.Dequeue() + ", ";
                }
                if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
                if (command == "Add")
                {
                    if (songsQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songName);
                    }
                    
                }
                if (!songsQueue.Any())
                {
                    Console.WriteLine("No more songs!");
                }
            }
        
           
        }
    }
}
