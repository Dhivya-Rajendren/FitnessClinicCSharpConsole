using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClinic_AzureRepo.Models
{
    public class Workout
    {
        public int WorkoutId { get; set; }
        public string WorkoutType { get; set; }
        public string WorkoutName { get; set; }
        public int DurationInMinutes { get; set; }
        public int CaloriesBurnt { get; set; }


        public override string ToString()
        {
            return "Type : " + WorkoutType + "\n Name  : " + WorkoutName + "\n Duration : " + DurationInMinutes + "\n CaloriesBurnt : " + CaloriesBurnt;
        }
    }
}
