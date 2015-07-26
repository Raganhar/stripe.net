namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null)
            : base(apiKey)
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                ApiKey = StripeConfiguration.GetApiKey();
            }
        }

        public virtual StripeAccount Get(StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var response = Requestor.GetString(Urls.Account, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions)
        {
            var postData = this.ApplyAllParameters(createOptions, "", false);

            //remove the ?
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostString(Urls.Accounts, new StripeRequestOptions { Data = postData });

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Get(string id)
        {
            var url = string.Format(Urls.SpecificAccount, id);

            var response = Requestor.GetString(url, new StripeRequestOptions());

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Update(string id, StripeAccountUpdateOptions updateOptions)
        {
            var postData = this.ApplyAllParameters(updateOptions, "", false);

            //remove the ?
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostString(string.Format(Urls.SpecificAccount, id), new StripeRequestOptions { Data = postData });

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        private static string RemoveQuestionMark(string source)
        {
            int index = source.IndexOf("?");
            string clean = (index < 0)
                ? source
                : source.Remove(index, "?".Length);

            return clean;
        }
    }
}