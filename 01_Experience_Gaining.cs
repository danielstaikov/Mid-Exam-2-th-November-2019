using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperiance = double.Parse(Console.ReadLine());
            int countOfBatles = int.Parse(Console.ReadLine());
            int counter = 1;
            double currentExperiance = 0.0;

            for(int i = 0; i<countOfBatles; i++)
            {
                double inputToken = double.Parse(Console.ReadLine());
                
                if(counter % 3 == 0)
                {
                    inputToken = inputToken * 1.15d;
                }
                if(counter % 5 == 0)
                {
                    inputToken = inputToken * 0.90d;
                }

                currentExperiance = currentExperiance + inputToken;
                if(currentExperiance >= neededExperiance)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
                    break;
                }
                counter++;
            }

            if (currentExperiance < neededExperiance)
            {
                double notEnoght = neededExperiance - currentExperiance;
                Console.WriteLine($"Player was not able to collect the needed experience, {notEnoght:F2} more needed.");
               
            }
        }
    }
}
