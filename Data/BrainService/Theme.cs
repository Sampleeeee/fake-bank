using System.Collections.Generic;
using System.Linq;

namespace Bank.Data
{
    public partial class BrainService
    {
        public List<Theme> Themes { get; set; } = new List<Theme> {
            new Theme
            {
                Name = "Default",
                PrimaryBackgroundColor = "#8bc34a",
                SecondaryBackgroundColor = "#4caf50",
                ButtonGroupAnchorColor = "white",
                ButtonGroupColor = "#8bc34a",
                AnchorColor = "blue",
                AnchorColor2 = "cyan",
                PreheaderAnchorColor = "black",
                HeaderAnchorColor = "black",
                HeaderNameColor = "white",
                FooterColor = "#eee",
                FooterTextColor = "black",
                LoginBoxColor = "#202020b3",
                RatesBackgroundColor = "##fff8ea",
                ShowPreheader = true,
                UseQuickLinks = true,
                UseAdvertisement = false,
                UseInbox = true,
                SidebarPosition = SidebarPosition.Left,
                AccountInfoStyle = AccountInfoStyle.Modern,
            },
            new Theme
            {
                Name = "Red",
                PrimaryBackgroundColor = "red",
                SecondaryBackgroundColor = "darkred",
                ButtonGroupAnchorColor = "white",
                ButtonGroupColor = "red",
                AnchorColor = "blue",
                AnchorColor2 = "cyan",
                PreheaderAnchorColor = "white",
                HeaderAnchorColor = "black",
                HeaderNameColor = "white",
                FooterColor = "#eee",
                FooterTextColor = "black",
                LoginBoxColor = "#202020b3",
                RatesBackgroundColor = "#fff8ea",
                ShowPreheader = false,
                UseQuickLinks = false,
                UseAdvertisement = true,
                UseInbox = true,
                SidebarPosition = SidebarPosition.Right,
                AccountInfoStyle = AccountInfoStyle.Compact,
            }
        };

        /// <summary>
        /// Sets the current <see cref="Theme" />
        /// </summary>
        public Theme CurrentTheme =>
            Themes.First(x => x.Name == "Red");
    }

    public class Theme
    {
        /// <summary>
        /// The name of the theme
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Primary background color for the website
        /// </summary>
        public string PrimaryBackgroundColor { get; set; }

        /// <summary>
        /// Secondary background color
        /// </summary>
        public string SecondaryBackgroundColor { get; set; }

        /// <summary>
        /// Color of links when buttons are in large groups. 
        /// ex. <see cref="Shared.Components.Account.ButtonGroup" />
        /// </summary>
        public string ButtonGroupAnchorColor { get; set; }

        /// <summary>
        /// Color for all <see cref="Shared.Components.ButtonGroup" />
        /// </summary>
        public string ButtonGroupColor { get; set; }

        /// <summary>
        /// Color of links
        /// </summary>
        public string AnchorColor { get; set; }

        /// <summary>
        /// The color of links in the <see cref="Shared.Components.Preheader" />
        /// </summary>
        public string PreheaderAnchorColor { get; set; }

        /// <summary>
        /// The color of links in the <see cref="Shared.Components.Navbar" />
        /// </summary>
        public string HeaderAnchorColor { get; set; }

        /// <summary>
        /// The color of the bank name in <see cref="Shared.Components.Navbar" />
        /// </summary>
        public string HeaderNameColor { get; set; }

        /// <summary>
        /// The color of the <see cref="Shared.Components.Footer" />
        /// </summary>
        public string FooterColor { get; set; }

        /// <summary>
        /// <see cref="Shared.Components.Footer" /> text color
        /// </summary>
        public string FooterTextColor { get; set; }

        /// <summary>
        /// Login Box background color
        /// </summary>
        public string LoginBoxColor { get; set; }

        /// <summary>
        /// Color for links in harder to see areas 
        /// (such as black backgrounds)
        /// </summary>
        public string AnchorColor2 { get; set; }

        /// <summary>
        /// Background color for the rates section of the homepage
        /// </summary>
        public string RatesBackgroundColor { get; set; }

        /// <summary>
        /// Should we show the preheader?
        /// </summary>
        public bool ShowPreheader { get; set; }

        /// <summary>
        /// Should the <see cref="Shared.Components.Account.QuickLinks" /> display?
        /// </summary>
        public bool UseQuickLinks { get; set; }

        /// <summary>
        /// Should the <see cref="Shared.Components.Account.Advertisement" /> display?
        /// </summary>
        public bool UseAdvertisement { get; set; }

        /// <summary>
        /// Should the <see cref="Shared.Components.Account.Inbox" /> display?
        /// </summary>
        public bool UseInbox { get; set; }

        /// <summary>
        /// Where should the sidebar on the accounts page be displayed?
        /// </summary>
        public SidebarPosition SidebarPosition { get; set; }

        /// <summary>
        /// Style of the <see cref="Shared.Components.Account.AccountInfo" />
        /// </summary>
        public AccountInfoStyle AccountInfoStyle { get; set; }

        public Theme() { }
    }

    public enum SidebarPosition
    {
        Left, Right
    }

    public enum AccountInfoStyle
    {
        Modern, Compact
    }
}