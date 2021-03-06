﻿using Stripe.Services.Disputes;

namespace Stripe
{
    public class StripeDisputeService : StripeService
    {
        public StripeDisputeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeDispute Update(string chargeId, StripeDisputeUpdateOptions evidence = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);
            var url = string.Format("{0}/{1}/dispute", Urls.Charges, chargeId);

            //var url = string.Format("{0}/dispute", chargeId);
            //url = this.ApplyAllParameters(null, url, false);
        //public virtual StripeDispute Update(string chargeId, StripeDisputeUpdateOptions evidence = null)
        //{

            url = this.ApplyAllParameters(evidence, url, true);
            
            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeDispute>.MapFromJson(response);
        }

        //public virtual StripeDispute Close(string chargeId)
        //{
        //    var url = string.Format("{0}/{1}/dispute/close",Urls.Charges, chargeId);
        //    url = this.ApplyAllParameters(null, url, false);

        //    var response = Requestor.PostString(url, ApiKey);

        //    return Mapper<StripeDispute>.MapFromJson(response);
        //}

        public virtual StripeDispute Close(string chargeId, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format("{0}/{1}/dispute/close", Urls.Charges, chargeId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeDispute>.MapFromJson(response);
        }
    }
}