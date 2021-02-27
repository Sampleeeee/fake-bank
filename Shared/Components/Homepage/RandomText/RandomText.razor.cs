using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.Homepage.RandomText
{

    public partial class RandomText
    {
        [Inject] private BrainService Brain { get; set; }
    }
}