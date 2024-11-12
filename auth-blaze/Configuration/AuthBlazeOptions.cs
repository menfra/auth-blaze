using System;
using System.Collections.Generic;
using System.Text;

namespace auth_blaze.Configuration
{
    public class AuthBlazeOptions
    {
        public bool EnableMFA { get; set; }
        public bool RestrictByGeolocation { get; set; }
        public bool TokenValidation { get; set; }
        public List<string> AllowedGeolocations { get; set; } = new List<string>();
    }
}
