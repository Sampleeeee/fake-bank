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

        // FIXME this is fucking gay, why can't I just use css. This *only* works as a Style
        private readonly string BgStyle = "width: 50%; border-bottom: 2px solid #fff;border-right: 2px solid #fff;";
    }
}