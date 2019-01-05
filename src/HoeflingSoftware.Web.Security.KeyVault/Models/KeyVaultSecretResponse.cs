﻿using Newtonsoft.Json;

namespace HoeflingSoftware.Web.Security.KeyVault.Models
{
    [JsonObject]
    internal class KeyVaultSecretResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}