using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.Footer
{
    public partial class Footer
    {
        [Inject] private BrainService Brain { get; set; }

        private string Copyright =>
            Brain.Get("Copyright");
    }
}