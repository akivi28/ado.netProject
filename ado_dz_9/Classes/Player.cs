using ado_dz_7.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_dz_9.Classes
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public int Number { get; set; }
        public string Position { get; set; } = default!;
        public int CountryId { get; set; }
        public Country Country { get; set; } = default!;
        public int TeamId { get; set; } 
        public Team Team { get; set; } = default!;

        public ICollection<Goal> Goals { get; set; }


        public Player() { 
            Goals = new List<Goal>();   
        } 

    }

}
