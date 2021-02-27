using System;
using System.Linq;
using System.Collections.Generic;
using System.Timers;

namespace Bank.Data
{
    public partial class BrainService
    {
        public bool LoggedIn { get; set; } = false;
        public string CurrentUser { get; set; }
        public DateTime LoggedInAt { get; set; }
        public string InactivityDisplay = "none";

        private List<User> Users = new List<User>
        {
            // Username: First letter of first name, lastname
            // Ex: bmays
            new User {
                FirstName = "Billy",
                LastName = "Mays",
                UnreadMessages = 5,
                Accounts = new List<User.Account>
                {
                    new User.Account
                    {
                        Name = "Premium Checking",
                        BaseBalance = 55898.71f,
                        Last4Digits = 4278,
                        PastTransactions = new List<User.Account.Transaction>
                        {
                            new User.Account.Transaction("****1930", "Balance Transfer", 50000f),
                            new User.Account.Transaction("APL*ITUNES.COM/BILL", "Debit", -50f),
                            new User.Account.Transaction("Netflix", "Debit", -14.99f),
                            new User.Account.Transaction("WINRAR", "Debit", -29.98f),
                            new User.Account.Transaction("AT&T", "Debit", -129.99f),
                            new User.Account.Transaction("Check #3193", "Deposit", 823.32f),
                            new User.Account.Transaction("In-N-Out", "Debit", -15.99f),
                            new User.Account.Transaction("Blockbuster", "Debit", -35.99f),
                            new User.Account.Transaction("PG&E /Autopay", "ACH Transfer", 2492.24f),
                            new User.Account.Transaction("Red Cross Red Shield", "Debit", -85.99f),
                            new User.Account.Transaction("America Online", "Debit", -19.99f),
                            new User.Account.Transaction("Allstate Insurance", "Check", 194.22f)
                        }
                    },
                    new User.Account
                    {
                        Name = "Savings Account",
                        BaseBalance = 26594.00f,
                        Last4Digits = 1930,
                        PastTransactions = new List<User.Account.Transaction>
                        {
                            // TODO This
                        }
                    },
                    new User.Account
                    {
                        Name = "Bronze Credit Card",
                        BaseBalance = 1645.71f,
                        Last4Digits = 4015,
                        PastTransactions = new List<User.Account.Transaction>
                        {
                            // TODO This
                        }
                    }
                }
            }
        };

        public void InactivityDismissed()
        {
            LoggedIn = false;
            CurrentUser = null;
        }

        public void Logout()
        {
            LoggedIn = false;
            CurrentUser = null;
        }

        public bool DoesUserExist(string username) =>
            Users.FirstOrDefault(x => x.Username == username) != null;

        public void AddTransaction(User.Account account, User.Account.Transaction transaction) =>
            account.PastTransactions.Add(transaction);

        public void Login(string username)
        {
            CurrentUser = username;
            LoggedIn = true;
            LoggedInAt = DateTime.Now;
        }

        public User GetCurrentUser() =>
            Users.Where(x => x.Username == CurrentUser).FirstOrDefault();

        public List<User.Account> GetCurrentAccounts() =>
            Users
                .Where(x => x.Username == CurrentUser)
                .First()
                .Accounts;
    }
}
