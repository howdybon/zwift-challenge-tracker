﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json;
using System.Linq;

namespace Zwift_Challenge.Data
{
    public class ZwiftChallengeService
    {
        private static readonly string _workoutFilePath = @"Data/WorkoutDataRecords.json";
        private static readonly string _contestFilePath = @"Data/ContestWinners.json";
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

        public async Task<List<WorkoutData>> GetWorkoutRecords()
        {
            var textFromFile = File.ReadAllText(_workoutFilePath);
                
            var toReturn =  JsonSerializer.Deserialize<List<WorkoutData>>(textFromFile);

            return toReturn;
        }

        public async Task SaveWorkoutRecords(IList<WorkoutData> workoutDataRecords)
        {
            var textToSave = JsonSerializer.Serialize(workoutDataRecords);
            await File.WriteAllTextAsync(_workoutFilePath, textToSave);
        }

        public async Task<List<ContestWinner>> GetContestsWinners()
        {
            var textFromFile = File.ReadAllText(_contestFilePath);

            var toReturn = JsonSerializer.Deserialize<List<ContestWinner>>(textFromFile);

            toReturn = toReturn.OrderByDescending(r => r.MonthNumber).ToList();

            return toReturn;
        }

    }
}
