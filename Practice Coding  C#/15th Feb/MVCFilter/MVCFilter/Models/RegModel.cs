using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilter.Models
{

    public class RegModel
    {
        public RegModel() {
            Interests = new List<string>();
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public List<string> Interests { get; set; }
    }
}