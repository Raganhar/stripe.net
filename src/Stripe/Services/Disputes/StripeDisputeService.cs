namespace Stripe
{
    public class StripeDisputeService : StripeService
    {
        public StripeDisputeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeDispute Update(string chargeId, string evidence = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/dispute", chargeId);
            url = this.ApplyAllParameters(null, url, false);

            if (!string.IsNullOrEmpty(evidence))
                url = ParameterBuilder.ApplyParameterToUrl(url, "evidence", evidence);

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