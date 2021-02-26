using System;
using System.Linq;
using System.Collections.Generic;
using System.Timers;

namespace Bank.Data
{
    public class BrainService
    {
        public bool LoggedIn { get; set; } = true;
        public string CurrentUser { get; set; } = "bmays";
        public DateTime LoggedInAt { get; set; }
        public string InactivityDisplay = "none";

        private readonly Dictionary<string, string> Configuration = new Dictionary<string, string> {
            { "Bank Name", "Second Community American Mutual" }, // SCAM 😎
            
            { "Copyright", "MWNAYFYP LTAP FAILRP LLC" },

            { "Dog Headline Title", "Hello There!" },
            { "Dog Headline Text", "Investing is likea box of chocolates, you never know what you're going to get!\nCheck the dictionary, we're there.\nBuying high, so you can sell low.\nTrusting your bank should be easy, so that's what you should do.\nAsk about oru low interest CD rates.\nNow offering fixed rate war bonds." },

            { "Mobile Banking", "Download our state of the art mobile banking suite today!" },

            { "Three Things 1 Title", "Auto Loan Center" },
            { "Three Things 1 Text", "If you think all banks are the same then you're right. It's money money money baby." },
            { "Three Things 2 Title", "Education Center" },
            { "Three Things 2 Text", "Let's think for a second what life would be like if everyone read books everyday." },
            { "Three Things 3 Title", "" }, // Leave these two blank so mobile banking
            { "Three Things 3 Text", "" },  // is positioned in a good spot
            
            { "Homepage RandomText Title", "Banking doesn't need to be complicated, but it is anyways." },
            { "Homepage RandomText Text", "We're passionate about getting your money in our bank and will stop at nothing to make it happen. In todays dog-eat-dog-eat-cat-eat-bird-eat-worm world we have to rely on powerful allies. As said powerful allies to many powerful world leaders, we can be the answer to your problems. Did you know banking can solve a world of problems? We solve the worlds problems of tomorrow, today. We put the you in community. There's no physical branches so we can keep the saving flowing." },

            { "Rates 1 Title", "Online Transfers" },
            { "Rates 1 Rate", "0.42%" },
            { "Rates 2 Title", "Credit Card" },
            { "Rates 2 Rate", "0.12%" },
            { "Rates 3 Title", "International" },
            { "Rates 3 Rate", "1.37%" },
        };

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

        public BrainService()
        {
            // InactivityTimer();
        }

        // private void InactivityTimer()
        // {
        //     Timer timer = new Timer(100);
        //     timer.AutoReset = true;
        //     timer.Elapsed += (_, _) =>
        //     {
        //         if (LoggedIn == true && DateTime.Now >= LoggedInAt.AddSeconds(10))
        //         {
        //             InactivityDisplay = "block";
        //         }
        //     };
        //     timer.Enabled = true;
        // }

        public void InactivityDismissed()
        {
            LoggedIn = false;
            CurrentUser = null;
        }

        public bool DoesUserExist(string username) =>
            Users.FirstOrDefault(x => x.Username == username) != null;

        public string Get(string key) =>
            Configuration.ContainsKey(key) ? Configuration[key] : "Configuration not found";

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
