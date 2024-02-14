using ado_dz_7.Classes;
using ado_dz_9.Classes;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;

namespace ado_dz_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ÑhampionshipContext context = new ÑhampionshipContext();

        private async void Form1_Load(object sender, EventArgs e)
        {
            await context.Countries
                .Include(t => t.Players)
                .LoadAsync();
            await context.Players
                .Include(t => t.Goals)
                .LoadAsync();
            await context.Teams
                .Include(t => t.HomeGames)
                .Include(t => t.AwayGames)
                .Include(t => t.Players)
                .LoadAsync();
            await context.Games
                .Include(t => t.HomeTeam)
                .Include(t => t.AwayTeam)
                .LoadAsync();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            dataGridView1.DataSource = context.Teams
                                .Select(t => new { t.Name, GoalsDifferences = Math.Abs(t.LostGoals - t.ScoreGoals) }).ToList();
                        }
                        break;
                    case 1:
                        {
                            dataGridView1.DataSource = context.Games
                                .Select(t => new
                                {
                                    t.GameDate,
                                    HomeTeamName = t.HomeTeam.Name,
                                    AwayTeamName = t.AwayTeam.Name,
                                    t.GoalsHomeTeam,
                                    t.GoalsAwayTeam,
                                }).Take(1)
                                .ToList();
                        }
                        break;
                    case 2:
                        {
                            dataGridView1.DataSource = context.Games
                                .Select(t => new
                                {
                                    t.GameDate,
                                    HomeTeamName = t.HomeTeam.Name,
                                    AwayTeamName = t.AwayTeam.Name,
                                    t.GoalsHomeTeam,
                                    t.GoalsAwayTeam,
                                })
                                .Where(t => t.GameDate.Date == DateTime.Parse("01.09.2023").Date)
                                .ToList();
                        }
                        break;
                    case 3:
                        {
                            dataGridView1.DataSource = context.Games
                                   .Where(t => t.HomeTeam.Name == "Team Germany" || t.AwayTeam.Name == "Team Germany")
                                   .Select(t => new
                                   {
                                       t.GameDate,
                                       HomeTeamName = t.HomeTeam.Name == "Team Germany" ? t.HomeTeam.Name : t.AwayTeam.Name,
                                       AwayTeamName = t.AwayTeam.Name != "Team Germany" ? t.AwayTeam.Name : t.HomeTeam.Name,
                                       t.GoalsHomeTeam,
                                       t.GoalsAwayTeam,
                                   })

                                   .ToList();
                        }
                        break;
                    case 4:
                        {
                            dataGridView1.DataSource = context.Goals
                                .Where(g => g.Game.GameDate.Date == DateTime.Parse("01.09.2023").Date)
                                .Select(g => new { g.Player.FullName })
                                .ToList();
                        }
                        break;
                    case 5:
                        {
                            dataGridView1.DataSource = context.Games
                                .Select(t => new
                                {
                                    t.GameDate,
                                    HomeTeamName = t.HomeTeam.Name,
                                    AwayTeamName = t.AwayTeam.Name,
                                    t.GoalsHomeTeam,
                                    t.GoalsAwayTeam,
                                })
                                .ToList();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}