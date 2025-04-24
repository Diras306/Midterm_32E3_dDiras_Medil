using System;

namespace SlotMachineBackend.Models
{
    public class GameResult
    {
        public int Id { get; set; }
        public string StudentNumber { get; set; }
        public string Outcome { get; set; } 
        public DateTime DatePlayed { get; set; }
    }
}