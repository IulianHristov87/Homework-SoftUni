using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Football.Models
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;
        private const int MinimumAllowedYear = 1850;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name should be at least 5 chars long");
                }
                this.name = value;
            }
        }
        public string Nickname
        {
            get
            {
                return this.nickname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Nickname should be at least 5 chars long");
                }
                this.nickname = value;
            }
        }
        public DateTime DateFounded 
        {
            get
            {
                return this.dateFounded;
            }
            set
            {
                if(value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Date founded cannot be earlier than " + MinimumAllowedYear);
                }
                this.dateFounded = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get
            {
                return this.players;
            }
        }

        public void AddPlayer(Player player)
        {
            if()
        }
    }
}
