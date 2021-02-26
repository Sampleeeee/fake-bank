using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.Account.Inbox
{
    public partial class Inbox
    {
        [Inject] private BrainService Brain { get; set; }

        private int NumUnread =>
            Brain.GetCurrentUser().UnreadMessages;
    }
}