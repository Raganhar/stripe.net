namespace Stripe
{
    public class StripeDisputeService : StripeService
    {
        public StripeDisputeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandBalanceTransaction { get; set; }

<<<<<<< HEAD
        public virtual StripeDispute Update(string chargeId, string evidence = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/dispute", chargeId);
            url = this.ApplyAllParameters(null, url, false);
=======
        public virtual StripeDispute Update(string chargeId, StripeDisputeUpdateOptions evidence = null)
        {
            var url = string.Format("{0}/{1}/dispute",Urls.Charges, chargeId);

            url = this.ApplyAllParameters(evidence, url, true);
            
            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeDispute>.MapFromJson(response);
        }
>>>>>>> ed98b36b7c5fe636072e53fe395c6a80be64347d

        public virtual StripeDispute Close(string chargeId)
        {
            var url = string.Format("{0}/{1}/dispute/close",Urls.Charges, chargeId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeDispute>.MapFromJson(response);
        }

        public virtual StripeDispute Close(string chargeId, StripeRequestOptions requestOptions)
        {
            var url = string.Format("{0}/{1}/dispute/close", Urls.Charges, chargeId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.PostString(url, requestOptions);





            return Mapper<StripeDispute>.MapFromJson(response);
        }
    }
}