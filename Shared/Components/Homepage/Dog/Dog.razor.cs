using System;
using Bank.Data;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bank.Shared.Components.Homepage.Dog
{
    public partial class Dog
    {
        [Inject] private BrainService Brain { get; set; }
        [Inject] private NavigationManager Navigation { get; set; }

        private string Username { get; set; }

        private List<string> MathProblems = new List<string>
        {
            "𝑥⁴ + 25𝑥³ + 4𝑖√(5𝑥²) - 69𝑥 + 420",
            "let ƒ(𝑥) = ⅞𝑥⁹ - (52𝑥⁴ + 2𝑥³); what is ƒ(-512)",
            "For 𝑥 such that 0 < 𝑥 < (π / 2), (√(1 - sin² 𝑥) / sin 𝑥)",
            "ƒ(2𝑎) + 2ƒ(𝑏) = ƒ(ƒ(𝑎 + 𝑏)); Solve for all ƒ: 𝕫 -> 𝕫",
            "𝑒^(π√(-1)) + 1",
            "1 - (𝑥 - 1) / (√(𝑥 + 1)) = 9𝑥; Solve for 𝑥"
        };

        private string MathAnswerValue { get; set; } = string.Empty;
        private string TwoFactorValue { get; set; } = string.Empty;

        private string usernameStyle = string.Empty;

        private bool showMathProblem = false;
        private bool showTwoFactor = false;
        private bool showLoading = false;

        private string mathProblem = string.Empty;
        private bool showBadcode = false;

        private void ShowTwoFactor() =>
            showTwoFactor = true;

        private void HideTwoFactor() =>
            showTwoFactor = false;

        private void ShowMath()
        {
            showBadcode = false;
            showMathProblem = true;
            mathProblem = MathProblems[new Random().Next(MathProblems.Count)];
        }

        private void HideMath() =>
            showMathProblem = false;

        private async Task SubmitMathProblem()
        {
            try
            {
                if (Convert.ToInt32(MathAnswerValue) <= 3)
                {
                    HideMath();
                    showLoading = true;

                    await Task.Delay(500);

                    Brain.Login(Username);

                    await Task.Delay(1000);

                    Navigation.NavigateTo("/account");
                }
                else showBadcode = true;
            }
            catch
            {
                showBadcode = true;
            }
        }

        private async Task SubmitTwoFactor()
        {
            try
            {
                TwoFactorValue = TwoFactorValue.Replace(" ", "");

                if (TwoFactorValue.Length == 6 && Convert.ToInt32(TwoFactorValue) > -1)
                {
                    HideTwoFactor();
                    showLoading = true;

                    await Task.Delay(500);

                    Brain.Login(Username);

                    await Task.Delay(1000);

                    Navigation.NavigateTo("/account");
                }
                else showBadcode = true;
            }
            catch
            {
                showBadcode = true;
            }
        }

        private void OnLoginClicked()
        {
            // TODO Verify Login is a valid user
            if (!Brain.DoesUserExist(Username))
            {
                usernameStyle = "border: 5px solid red;";
                return;
            }

            if (!string.IsNullOrEmpty(usernameStyle))
                usernameStyle = string.Empty;

            Random random = new Random();
            if (random.Next(0, 2) == 0)
                ShowMath();
            else
                ShowTwoFactor();
        }
    }
}