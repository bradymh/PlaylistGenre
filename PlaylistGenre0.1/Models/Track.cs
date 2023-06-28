using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistGenre0._1.Models
{
    public class Track
    {
        public string Added_At { get; set; }
        public AddedBy Added_By { get; set; }
        public bool Is_Local { get; set; }
        public Album Album { get; set; }
        public List<Artist> Artists { get; set; }
        public List<string> Available_Markets { get; set; }
        public int Disc_Number { get; set; }
        public int Duration_Ms { get; set; }
        public bool Explicit { get; set; }
        public ExternalIds External_Ids { get; set; }
        public ExternalUrls External_Urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public bool Is_Playable { get; set; }
        public object Linked_From { get; set; }
        public object Restrictions { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string Preview_Url { get; set; }
        public int Track_Number { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class Tracks
    {
        public string Href { get; set; }
        public int Limit { get; set; }
        public string Next { get; set; }
        public int Offset { get; set; }
        public string Previous { get; set; }
        public int Total { get; set; }
        public List<PlaylistItem> Items { get; set; }
    }
}
