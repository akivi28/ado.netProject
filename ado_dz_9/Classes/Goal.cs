using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_dz_9.Classes
{
    public class Goal
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; } = default!;
        public int PlayerId { get; set; }

        public Player Player { get; set; } = default!;
    }
}
