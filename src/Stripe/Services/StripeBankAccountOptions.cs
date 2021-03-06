﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBankAccountOptions
    {
        [JsonProperty("bank_account")]
        public string TokenId { get; set; }

        [JsonProperty("bank_account[country]")]
        public string Country { get; set; }

        [JsonProperty("bank_account[currency]")]
        public string Currency { get; set; }
        [JsonProperty("bank_account[routing_number]")]
        public string RoutingNumber { get; set; }

        [JsonProperty("bank_account[account_number]")]
        public string AccountNumber { get; set; }
    }
}