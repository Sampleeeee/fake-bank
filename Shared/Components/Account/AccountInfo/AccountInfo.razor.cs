using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Bank.Shared.Components.Account.AccountInfo
{
    public partial class AccountInfo
    {
        [Inject] private BrainService Brain { get; set; }
    }
}