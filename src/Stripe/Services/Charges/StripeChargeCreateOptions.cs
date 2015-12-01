using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace Stripe
{
    public class StripeChargeCreateOptions
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }
<<<<<<< HEAD
   [JsonProperty("card")]
        public string SourceId { get; set; }
        [JsonProperty("source")]
        public StripeSourceOptions Source { get; set; }
=======

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }
>>>>>>> ed98b36b7c5fe636072e53fe395c6a80be64347d

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("capture")]
        public bool? Capture { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

<<<<<<< HEAD
        [JsonProperty("shipping")]
        public Dictionary<string, string> Shipping { get; set; }
=======
        [JsonProperty("destination")]
        public string Destination { get; set; }
>>>>>>> ed98b36b7c5fe636072e53fe395c6a80be64347d
    }
}