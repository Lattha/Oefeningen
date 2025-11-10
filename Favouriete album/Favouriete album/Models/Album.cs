using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favouriete_album.Models
{
    internal class Album
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int NumberSongs { get; set; }
        public int DurationInMinutes { get; set; }
        public string FormattedDate
        {
            get
            {
                return ReleaseDate.ToString("dd/MM/yyyy");
            }
        }
        public string FormattedDuration
        {
            get
            {
                TimeSpan duration = TimeSpan.FromMinutes(DurationInMinutes);
                return duration.ToString(@"hh\:mm\:ss");
            }
        }
    }
} 

