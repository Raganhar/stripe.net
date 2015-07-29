using System;
using System.Collections.Generic;

namespace Stripe.Tests.account.test_data
{
    public static class stripe_managed_account_create_options
    {
        public static StripeAccountCreateOptions ValidUser(string countryCode = null, string email = null, string ip = null)
        {
            var accountCreateOptions = new StripeAccountCreateOptions
            {
                Country = countryCode ??"US",
                Email = email??"Someone@email.com",
                TosAcceptanceIp = ip??"2.168.0.1",
                Managed = "true",
                TosAcceptanceDate = DateTime.Now.Ticks
            };

            return accountCreateOptions;
        }
    }
}
