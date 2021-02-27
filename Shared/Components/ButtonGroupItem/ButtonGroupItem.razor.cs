using Microsoft.AspNetCore.Components;

namespace Bank.Shared.Components.ButtonGroupItem
{
    using Data;

    public partial class ButtonGroupItem
    {
        [Inject] private BrainService Brain { get; set; }
        [Parameter] public string Style { get; set; }
        [Parameter] public string Class { get; set; }
        [Parameter] public string Glyph { get; set; }
        [Parameter] public GlyphPosition GlyphPosition { get; set; } = GlyphPosition.Left;
        [Parameter] public RenderFragment ChildContent { get; set; }
    }

    public enum GlyphPosition
    {
        Left, Right
    }
}