using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistGenre0._1.Models
{
    public class Artist
    {
        public ExternalUrls ExternalUrls { get; set; }
        public Followers Followers { get; set; }
        public List<string> Genres { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}
