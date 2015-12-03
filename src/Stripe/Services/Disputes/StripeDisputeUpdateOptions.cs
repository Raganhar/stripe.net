﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe.Services.Disputes
{
    public class StripeDisputeUpdateOptions
    {
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("customer_email_address")]
        public string CustomerEmailAddress { get; set; }

        [JsonProperty("customer_purchase_ip")]
        public string CustomerPurchaseIp { get; set; }

        [JsonProperty("customer_signature")]
        public string CustomerSignature { get; set; }

        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("shipping_date")]
        public string ShippingDate { get; set; }

        [JsonProperty("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonProperty("shipping_tracking_number")]
        public string ShippingTrackingNumber { get; set; }

        [JsonProperty("shipping_documentation")]
        public string ShippingDocumentation { get; set; }

        [JsonProperty("access_activity_log")]
        public string AccessActivityLog { get; set; }

        [JsonProperty("service_date")]
        public string ServiceDate { get; set; }

        [JsonProperty("service_documentation")]
        public string ServiceDocumentation { get; set; }

        [JsonProperty("duplicate_charge_id")]
        public string DuplicateChargeId { get; set; }

        [JsonProperty("duplicate_charge_explanation")]
        public string DuplicateChargeExplanation { get; set; }

        [JsonProperty("refund_policy")]
        public string RefundPolicy { get; set; }

        [JsonProperty("refund_policy_disclosure")]
        public string RefundPolicyDisclosure { get; set; }

        [JsonProperty("refund_refusal_explanation")]
        public string RefundRefusalExplanation { get; set; }

        [JsonProperty("cancellation_policy")]
        public string CancellationPolicy { get; set; }

        [JsonProperty("cancellation_policy_disclosure")]
        public string CancellationPolicyDisclosure { get; set; }

        [JsonProperty("cancellation_rebuttal")]
        public string CancellationRebuttal { get; set; }

        [JsonProperty("customer_communication")]
        public string CustomerCommunication { get; set; }

        [JsonProperty("uncategorized_file")]
        public string UncategorizedFile { get; set; }

        [JsonProperty("evidence[uncategorized_text]")]
        public string UncategorizedText { get; set; }
    }
}
