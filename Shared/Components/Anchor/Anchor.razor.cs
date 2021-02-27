using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;

namespace Bank.Shared.Components.Anchor
{
    public partial class Anchor
    {
        [Inject] private NavigationManager Navigation { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Location { get; set; }
        [Parameter] public string Color { get; set; } = "#0000EE";
        [Parameter] public string Style { get; set; }
        [Parameter] public string Class { get; set; }
        [Parameter] public Action<MouseEventArgs> OnClick { get; set; }

        private void OnClicked(MouseEventArgs e)
        {
            if (OnClick != null)
            {
                OnClick(e);
                return;
            }

            if (!string.IsNullOrEmpty(Location))
                Navigation.NavigateTo(Location);
        }
    }
}