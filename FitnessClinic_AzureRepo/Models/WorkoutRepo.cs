using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClinic_AzureRepo.Models
{
   public class WorkoutRepo
    {
        List<Workout> workouts = new List<Workout>()
        {
            new Workout(){WorkoutId=1,WorkoutType="Body Building",WorkoutName="Climbing",DurationInMinutes=30,CaloriesBurnt=250},
            new Workout(){WorkoutId=2,WorkoutType="Muscle Building",WorkoutName="Pushups",DurationInMinutes=10,CaloriesBurnt=50},
            new Workout(){WorkoutId=3,WorkoutType="Weight Loss",WorkoutName="Walking",DurationInMinutes=30,CaloriesBurnt=150},
            new Workout(){WorkoutId=4,WorkoutType="Weight Loss",WorkoutName="Jogging",DurationInMinutes=30,CaloriesBurnt=200},
        };

        public List<Workout> GetWorkouts()
        {
            return workouts;
        }
    }
}
