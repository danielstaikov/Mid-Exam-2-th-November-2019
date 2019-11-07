using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ownedTanks = Console.ReadLine().Split(", ").ToList();
            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommand; i++)
            {
                List<string> command = Console.ReadLine().Split(", ").ToList();
                switch (command[0])
                {
                    case "Add"://Add, {tankName}
                        if (ownedTanks.Contains(command[1]))
                        {
                            Console.WriteLine($"Tank is already bought");
                        }
                        else
                        {
                            ownedTanks.Add(command[1]);
                            Console.WriteLine($"Tank successfully bought");
                        }
                        break;
                    case "Remove"://Remove, {tankName}
                        if (ownedTanks.Contains(command[1]))
                        {
                            ownedTanks.Remove(command[1]);
                            Console.WriteLine($"Tank successfully sold");
                        }
                        else
                        {
                            Console.WriteLine($"Tank not found");
                        }
                        break;
                    case "Remove At"://Remove At, {index}
                        int index = int.Parse(command[1]);
                        if(index >= 0 && index < ownedTanks.Count)
                        {
                            ownedTanks.RemoveAt(index);
                            Console.WriteLine($"Tank successfully sold");
                        }
                        else
                        {
                            Console.WriteLine($"Index out of range");
                        }
                        break;
                    case "Insert"://Insert, {index}, {tankName}
                        int index2 = int.Parse(command[1]);
                        if (index2 >= 0 && index2 < ownedTanks.Count)
                        {
                            if(ownedTanks.Contains(command[2]))
                            {
                                Console.WriteLine($"Tank is already bought");
                            }
                            else
                            {
                                ownedTanks.Insert(index2,command[2]);
                                Console.WriteLine($"Tank successfully bought");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Index out of range");
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", ownedTanks));
        }
    }
}
