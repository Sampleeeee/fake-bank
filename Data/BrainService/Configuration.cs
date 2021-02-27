using System;
using System.Collections.Generic;

namespace Bank.Data
{
    public partial class BrainService
    {
        /// <summary>
        /// The name of the "bank".
        /// </summary>
        public string BankName = "Second Community American Mutual";

        /// <summary>
        /// Text show on the footer of the page.
        /// Allows html
        /// </summary>
        public string Footer = @"
            <p>Member FDIC: No. Rates and investment products are not insured.</p>
            <p>
                The bank information provided on this website is only valid for those living in states that end in G and no
                others. Any attempt to use this website without authorized access is prohibited by the 11th circuit court of
                the
                high magistrates. No offers may be made or accepted from any resident outside of these states due to various
                state
                regulations and registration requirements regarding investment products and services.
            </p>
            <p>&copy; Copyright MWNAYFYP LTAP FAILRP LLC</p>
        ";

        /// <summary>
        /// The text next to the login box. 
        /// </summary>
        public TitleTextPair Dog = new TitleTextPair
        (
            "Hello There!",
            new List<string>
            {
                "Investing is like a box of chocolates, you never know what you're going to get!",
                "Check the dictionary, we're there.",
                "Buying high, so you can sell low.",
                "Trusting your bank should be easy, so that's what you should do.",
                "Ask about our low interest CD rates.",
                "Now offering fixed rate war bonds."
            }
        );

        /// <summary>
        /// Mobile banking card on-top of the <see cref="ThreeThings" /> list
        /// </summary>
        public string MobileBanking = "Download our state of the art mobile banking suite today!";

        /// <summary>
        /// Below the login area of the main page.
        /// </summary>
        public TitleTextPair[] ThreeThings = new TitleTextPair[3]
        {
            new TitleTextPair(
                "Auto Loan Center",
                "If you think all banks are the same then you're right. It's money money money baby."
            ),
            new TitleTextPair
            (
                "Education Center",
                "Let's think for a second what life would be like if everyone read books everyday."
            ),
            new TitleTextPair
            (
                "", // Leave these two blank so the mobile
                ""  // banking app is in a good spot
            ),
        };

        /// <summary>
        /// Random text that goes below <see cref="ThreeThings" />
        /// Allows HTML
        /// </summary>
        public TitleTextPair RandomText = new TitleTextPair(
            "Banking doesn't need to be complicated, but it is anyways.",
            "We're passionate about getting your money in our bank and will stop at nothing to make it happen. In todays dog-eat-dog-eat-cat-eat-bird-eat-worm world we have to rely on powerful allies. As said powerful allies to many powerful world leaders, we can be the answer to your problems. Did you know banking can solve a world of problems? We solve the worlds problems of tomorrow, today. We put the you in community. There's no physical branches so we can keep the saving flowing."
        );

        /// <summary>
        /// Rates below <see cref="RandomText">
        /// </summary>
        public TitleTextPair[] Rates = new TitleTextPair[3]
        {
            new TitleTextPair("Online Transfers", "0.42%"),
            new TitleTextPair("Credit Card", "0.12%"),
            new TitleTextPair("International", "1.37%")
        };

        [Obsolete("Use class properties instead.", true)]
        public string Get(string key) =>
            "This is obsolete";
    }

    /// <summary>
    /// Used in <see cref="BrainService" /> for configuration.
    /// Contains a title and description.
    /// </summary>
    public class TitleTextPair
    {
        private readonly string title = string.Empty;
        private readonly string text = string.Empty;

        private readonly List<string> textOptions;

        public string Title { get { return title; } }
        public string Text
        {
            get
            {
                if (textOptions != null)
                    return textOptions[new Random().Next(textOptions.Count)];
                else
                    return text;
            }
        }

        public TitleTextPair() { }

        public TitleTextPair(string title, string text)
        {
            this.title = title;
            this.text = text;
        }

        public TitleTextPair(string title, List<string> text)
        {
            this.title = title;
            textOptions = text;
        }
    }
}