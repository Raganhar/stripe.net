using Machine.Specifications;

namespace Stripe.Tests
{
    [Behaviors]
    public class account_behaviors
    {
      protected static StripeAccount StripeAccount;

        protected static StripeAccountService StripeAccountService;
        protected static StripeAccountCreateOptions StripeaccountCreateOptions;

        It should_have_an_id = () =>
            StripeAccount.Id.ShouldNotBeNull();
        It should_have_correct_country = () =>
            StripeAccount.Country.ShouldEqual(StripeaccountCreateOptions.Country);
    //    It should_have_correct_email = () =>
    //        StripeAccount.Email.ShouldBeTheSameAs(StripeAccountCreateOptions.Email);
    //    It should_have_correct_tos_ip = () =>
    //     StripeAccount.TosAcceptance.Ip.ShouldBeTheSameAs(StripeAccountCreateOptions.TosAcceptanceIp);
    //    It should_have_correct_tos_date = () =>
    //     StripeAccount.TosAcceptance.Date.ShouldBeTheSameAs(StripeAccountCreateOptions.TosAcceptanceDate);
    }
}