using System;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Collections.Generic;

namespace Bank.Pages.Transactions
{
    using Data;

    public partial class Transactions
    {
        [Inject] private BrainService Brain { get; set; }

        [Parameter] public int Digits { get; set; }

        private User.Account Account =>
            Brain.GetCurrentAccounts().FirstOrDefault(x => x.Last4Digits == Digits);

        private List<User.Account.Transaction> AllTransactions()
        {
            List<User.Account.Transaction> t = new List<User.Account.Transaction>();

            foreach (User.Account account in Brain.GetCurrentAccounts())
                t.AddRange(account.PastTransactions);

            return t;
        }
    }
}