using FitnessClinic_AzureRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClinic_AzureRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying the Workout details");
            WorkoutRepo repo = new WorkoutRepo();
            Console.WriteLine("------------------------");
            foreach (Workout item in repo.GetWorkouts())
            {
                Console.WriteLine(item);
            }
        }
    }
}
