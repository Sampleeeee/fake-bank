using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.Homepage.ThreeThings
{

    public partial class ThreeThings
    {
        [Inject] private BrainService Brain { get; set; }

        private string GetTitle(int num) =>
            Brain.Get($"Three Things {num} Title");

        private string GetText(int num) =>
            Brain.Get($"Three Things {num} Text");
    }
}