using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Bank.Shared.Components.Account.AccountInfo
{
    public partial class AccountInfo
    {
        [Inject] private BrainService Brain { get; set; }
        [Inject] private NavigationManager Navigation { get; set; }

        private void ViewTransactions(int digits) =>
            Navigation.NavigateTo($"/transactions/{digits}");

        private void MakeTransfer() =>
            Navigation.NavigateTo("/transfer");
    }
}