using ado_dz_9.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ado_dz_7.Classes
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int WinCount { get; set; }
        public int LostCount { get; set; }
        public int DrawCount { get; set; }
        public string City { get; set; } = default!;
        public int ScoreGoals { get; set; }
        public int LostGoals { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();

        public List<Game> HomeGames { get; set; } = new List<Game>();
        public List<Game> AwayGames { get; set; } = new List<Game>();
    }
}