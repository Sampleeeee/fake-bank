using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;

namespace Bank.Pages.Account
{
    public partial class Account
    {
        [Inject] private BrainService Brain { get; set; }

        private DateTime LastLoginDate =>
            DateTime.Now
            .AddDays(-2)
            .AddHours(-4)
            .AddMinutes(-27)
            .AddSeconds(-58);
    }
}