using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferCreateOptions
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

<<<<<<< HEAD
    [JsonProperty("destination")]
        public string Destination { get; set; }
=======
        [JsonProperty("destination")]
        public string Destination { get; set; }

>>>>>>> ed98b36b7c5fe636072e53fe395c6a80be64347d
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccountId { get; set; }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
