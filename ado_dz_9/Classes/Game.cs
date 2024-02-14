using ado_dz_7.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_dz_9.Classes
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime GameDate { get; set; }
        public int HomeTeamId { get; set; }

        public Team HomeTeam { get; set; } = default!;


        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; } = default!;

        public int GoalsHomeTeam { get; set; }
        public int GoalsAwayTeam { get; set; }

        public ICollection<Goal> Goals { get; set; }

        public Game()
        {
            Goals = new List<Goal>();
        }
    }

}
