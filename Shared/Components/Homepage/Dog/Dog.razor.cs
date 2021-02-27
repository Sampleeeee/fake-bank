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
            "x⁴ + 25x³ + i√5x² - 69x + 420",
            "let ƒ(x) = ⅞x⁹ - (52x⁴ + 2x³); what is ƒ(-512)"
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