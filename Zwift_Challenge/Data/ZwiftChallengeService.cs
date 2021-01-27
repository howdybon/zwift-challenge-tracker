using System;
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
    }
}
