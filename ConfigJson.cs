using Newtonsoft.Json;

namespace Kiranti_TestBot
{
    public struct ConfigJson
    {


        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
    }
}
