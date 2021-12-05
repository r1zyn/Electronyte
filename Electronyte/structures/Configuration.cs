using Newtonsoft.Json;

namespace Electronyte.structures
{
    struct Configuration
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
