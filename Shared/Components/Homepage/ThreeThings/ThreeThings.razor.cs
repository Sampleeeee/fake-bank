using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.Homepage.ThreeThings
{

    public partial class ThreeThings
    {
        [Inject] private BrainService Brain { get; set; }
    }
}