using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.Homepage.Rates
{

    public partial class Rates
    {
        [Inject] private BrainService Brain { get; set; }

        private string GetTitle(int num) =>
            Brain.Get($"Rates {num} Title");

        private string GetRate(int num) =>
            Brain.Get($"Rates {num} Rate");
    }
}