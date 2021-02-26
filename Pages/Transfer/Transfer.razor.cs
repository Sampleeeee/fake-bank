using System;
using System.Linq;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Bank.Pages.Transfer
{
    using Data;

    public partial class Transfer
    {
        [Inject] private NavigationManager Navigation { get; set; }
        [Inject] private BrainService Brain { get; set; }

        private float Amount { get; set; }
        private string TransferFrom { get; set; }
        private string TransferTo { get; set; }

        private async Task OnSubmit()
        {
            if (TransferFrom == null)
            {
                TransferFrom = Brain.GetCurrentAccounts()
                    .First()
                    .Last4Digits
                    .ToString();
            }

            if (TransferTo == null)
            {
                TransferTo = Brain.GetCurrentAccounts()
                    .First()
                    .Last4Digits
                    .ToString();
            }

            User.Account fromAccount = Brain.GetCurrentAccounts()
                .Where(x => x.Last4Digits.ToString() == TransferFrom)
                .FirstOrDefault();

            User.Account toAccount = Brain.GetCurrentAccounts()
                .Where(x => x.Last4Digits.ToString() == TransferTo)
                .FirstOrDefault();

            if (fromAccount == null || toAccount == null) return;
            if (fromAccount == toAccount) return;

            Brain.AddTransaction(fromAccount, new User.Account.Transaction($"Transfer to ****{TransferTo}", "Balance Transfer", -Amount, 0));
            Brain.AddTransaction(toAccount, new User.Account.Transaction($"Transfer from ****{TransferFrom}", "Balance Transfer", Amount, 0));

            await Task.Delay(500);

            Navigation.NavigateTo($"/transfer/success/{Guid.NewGuid()}");
        }
    }
}