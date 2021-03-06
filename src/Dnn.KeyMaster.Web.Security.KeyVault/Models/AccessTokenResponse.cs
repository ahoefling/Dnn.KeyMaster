﻿using Newtonsoft.Json;

namespace Dnn.KeyMaster.Web.Security.KeyVault.Models
{
    [JsonObject]
    internal class AccessTokenResponse
    {
        [JsonProperty("token_type")]
        public string Type { get; set; }

        [JsonProperty("access_token")]
        public string Token { get; set; }

        public override string ToString()
        {
            return $"{Type} {Token}";
        }
    }
}
