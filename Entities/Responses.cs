using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RenRen.Plurk.Entities
{
    public class GetPlurkResponse
    {
        [JsonProperty("plurk")]
        public Plurk Plurk { get; set; } = new();
        [JsonProperty("user")]
        public User User { get; set; } = new();
    }

    public class GetPlurksResponse
    {
        [JsonProperty("plurks")]
        public Plurk[] Plurks { get; set; } = [];
        [JsonProperty("plurk_users")]
        public Dictionary<int, User> PlurkUsers { get; set; } = [];
    }

    public class GetResponseResponse
    {
        [JsonProperty("friends")]
        public Dictionary<int, User> Friends { get; set; } = [];
        [JsonProperty("responses_seen")]
        public int ResponsesSeen { get; set; } = -1;
        [JsonProperty("responses")]
        public Response[] Responses { get; set; } = [];
    }

    public class ErrorResponse
    {
        [JsonProperty("error_text")]
        public string ErrorText { get; set; } = string.Empty;
    }
}
