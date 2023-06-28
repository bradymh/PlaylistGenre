using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistGenre0._1.Models
{
    public class UserProfile
    {        
        public string country { get; set; }
        public string display_name { get; set; }
        public string email { get; set; }
        public ExplicitContent explicit_content { get; set; }
        public ExternalUrls external_urls { get; set; }
        public Followers followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image[] images { get; set; }
        public string product { get; set; }
        public string type { get; set; }
        public string uri { get; set; }

        public class ExplicitContent
        {
            public bool filter_enabled { get; set; }
            public bool filter_locked { get; set; }
        }
    }
}
