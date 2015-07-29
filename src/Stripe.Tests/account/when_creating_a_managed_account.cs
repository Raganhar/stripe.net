using Machine.Specifications;
using Stripe.Tests.account.test_data;

namespace Stripe.Tests
{
    public class when_creating_a_managed_account
    {
        protected static StripeAccount StripeAccount;

        protected static StripeAccountService StripeAccountService;
        protected static StripeAccountCreateOptions StripeaccountCreateOptions;

        Establish context = () =>
        {
            StripeAccountService = new StripeAccountService();
            StripeaccountCreateOptions = stripe_managed_account_create_options.ValidUser();
        };

        Because of = () =>
        {
            StripeAccount = StripeAccountService.Create(StripeaccountCreateOptions);
        };

        Behaves_like<account_behaviors> behaviors;
    }
}
