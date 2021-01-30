using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zwift_Challenge.Data
{
    public class ZwiftChallengeService
    {
        private static readonly string[] Contestants = new[]
       {
            "Payton", "Robby", "Parker"

        };
        public ZwiftChallengeService()
        {
        }
        public async Task <string> GetWinner()
        {
            var random = new Random();
            var winnerIndex = random.Next(0, 3);
            var winner = Contestants[winnerIndex];
            return winner;
        }

        public async Task<IEnumerable<WorkoutData>> GetWorkoutsByMonth(string month)
        {
            var toReturn = GetMockData();
            return toReturn;
        }

        private IEnumerable<WorkoutData> GetMockData()
        {
            var toReturn = new List<WorkoutData>();

            var newWorkout = new WorkoutData
            {
                Calories = 1234,
                Elevation = 234,
                Time = new TimeSpan(2, 23, 23),
                Date = new DateTime(2021, 2, 2),
                Distance = (float)78.34,
                Rider = "Parker",
                Route = "Volcano"
            };
            toReturn.Add(newWorkout);

            toReturn.Add( new WorkoutData
            {
                Calories = 123,
                Elevation = 23,
                Time = new TimeSpan(0, 23, 23),
                Date = new DateTime(2021, 2, 2),
                Distance = (float)7.34,
                Rider = "Payton",
                Route = "Volcano"
            });

            toReturn.Add(new WorkoutData
            {
                Calories = 1,
                Elevation = 4,
                Time = new TimeSpan(0, 3, 23),
                Date = new DateTime(2021, 2, 2),
                Distance = (float)0.34,
                Rider = "Robby",
                Route = "Volcano"
            });

            
            return toReturn;
        }
    }
}
