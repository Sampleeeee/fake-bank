using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Bank.Shared.Components.Navbar
{
    public partial class Navbar
    {
        [Inject] private NavigationManager Navigation { get; set; }
        [Inject] private BrainService Brain { get; set; }

        private string BankName =>
            Brain.Get("Bank Name");

        protected override void OnInitialized()
        {
            Navigation.LocationChanged += (_, _) =>
                StateHasChanged();
        }
    }
}