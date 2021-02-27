using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;

namespace Bank.Shared.Components.Account.AccountInfo
{
    public partial class AccountInfo
    {
        [Inject] private BrainService Brain { get; set; }

        private List<User.Account.Transaction> AllTransactions()
        {
            List<User.Account.Transaction> t = new List<User.Account.Transaction>();

            foreach (User.Account account in Brain.GetCurrentAccounts())
                t.AddRange(account.PastTransactions);

            return t;
        }
    }
}