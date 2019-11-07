using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Friend_List_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendsList = Console.ReadLine().Split(", ");
            string inputToken = null;
            do
            {
                inputToken = Console.ReadLine();
                List<string> command = inputToken.Split().ToList();

                switch (command[0])
                {
                    case "Blacklist":
                        if (friendsList.Contains(command[1]))
                        {
                            int index2 = Array.IndexOf(friendsList, command[1]);
                            friendsList[index2] = "Blacklisted";
                            Console.WriteLine($"{command[1]} was blacklisted.");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} was not found.");
                        }
                        break;
                    case "Error"://Error {index}
                        if (friendsList[int.Parse(command[1])] != "Blacklisted" && friendsList[int.Parse(command[1])] != "Lost")
                        {
                            string name = friendsList[int.Parse(command[1])];
                            friendsList[int.Parse(command[1])] = "Lost";
                            Console.WriteLine($"{name} was lost due to an error.");
                        }
                        break;
                    case "Change": //Change {index} {newName}
                        int index3 = int.Parse(command[1]);
                        if (index3 >= 0 && index3 < friendsList.Length)
                        {
                            string currentName = friendsList[index3];
                            string newName = command[2];
                            friendsList[index3] = newName;
                            Console.WriteLine($"{currentName} changed his username to {newName}.");
                        }
                        break;

                }

            } while (inputToken != "Report");

            int countBlacklisted = 0;
            int countLost = 0;

            for (int i = 0; i < friendsList.Length; i++)
            {
                if (friendsList[i] == "Blacklisted")
                {
                    countBlacklisted++;
                }
                if (friendsList[i] == "Lost")
                {
                    countLost++;
                }

            }

            Console.WriteLine($"Blacklisted names: {countBlacklisted}");
            Console.WriteLine($"Lost names: {countLost}");
            Console.WriteLine(string.Join(" ", friendsList));
        }
    }
}
