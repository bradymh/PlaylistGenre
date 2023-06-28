using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistGenre0._1.Models
{
    public class Album
    {
        public string Album_Type { get; set; }
        public int Total_Tracks { get; set; }
        public List<string> Available_Markets { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }
        public string Release_Date { get; set; }
        public string Release_Date_Precision { get; set; }
        public object Restrictions { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
        public List<object> Copyrights { get; set; }
        public ExternalIds External_Ids { get; set; }
        public List<string> Genres { get; set; }
        public string Label { get; set; }
        public int Popularity { get; set; }
        public string Album_Group { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
