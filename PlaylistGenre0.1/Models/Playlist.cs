using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistGenre0._1.Models
{
    public class Playlist
    {
        public bool Collaborative { get; set; }
        public string Description { get; set; }
        public ExternalUrls External_Urls { get; set; }
        public Followers Followers { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }
        public Owner Owner { get; set; }
        public bool Public { get; set; }
        public string Snapshot_Id { get; set; }
        public Tracks Tracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }


    public class ExternalUrls
    {
        public string Spotify { get; set; }
    }

    public class Owner
    {
        public ExternalUrls ExternalUrls { get; set; }
        public Followers Followers { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
        public string Display_Name { get; set; }
    }

    public class AddedBy
    {
        public ExternalUrls ExternalUrls { get; set; }
        public Followers Followers { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class ExternalIds
    {
        public string Isrc { get; set; }
        public string Ean { get; set; }
        public string Upc { get; set; }
    }

    public class PlaylistItem
    {
        public string Added_At { get; set; }
        public AddedBy Added_By { get; set; }
        public bool Is_Local { get; set; }
        public Track Track { get; set; }
    }

}
