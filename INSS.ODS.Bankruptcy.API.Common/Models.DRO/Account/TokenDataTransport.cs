using System;
using Newtonsoft.Json;

namespace INSS.ODS.Bankruptcy.API.Common.Models.DRO.Account
{
    public class TokenDataTransport
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = ".issued")]
        public DateTime Issed { get; set; }

        [JsonProperty(PropertyName = ".expires")]
        public DateTime Expires { get; set; }

        public bool IsAuthenticated()
        {
            return !string.IsNullOrEmpty(AccessToken);
        }
    }
}