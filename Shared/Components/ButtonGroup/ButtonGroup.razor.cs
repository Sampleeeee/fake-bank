using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.ButtonGroup
{
    public partial class ButtonGroup
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Class { get; set; }
        [Parameter] public string Style { get; set; }
        [Parameter] public bool Wrap { get; set; }
    }
}