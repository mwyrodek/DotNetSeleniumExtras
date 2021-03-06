using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumExtras.Environment
{
    [JsonObject]
    public class WebsiteConfig
    {
        [JsonProperty]
        public string Protocol { get; set; }

        [JsonProperty]
        public string HostName { get; set; }

        [JsonProperty]
        public string Port { get; set; }

        [JsonProperty]
        public string SecurePort { get; set; }

        [JsonProperty]
        public string Folder { get; set; }
   }
}
