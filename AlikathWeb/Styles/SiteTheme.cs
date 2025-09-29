using MudBlazor;
using MudBlazor.Utilities;

namespace AlikathWeb.Theme
{
    public static class SiteTheme
    {
        public static readonly MudTheme Value = new()
        {
            //  rgba(255,255,255,1) - White
            //  rgba(242,242,242,1) - Background
            //  rgba(240,99,20,1) - Orange
            //  rgba(0,184,228,1) - Cyan
            //  rgba(51,51,51,1) - Light Gray
            //  rgba(32,33,35,1) - Dark Gray

            PaletteLight = new PaletteLight()
            {
                Primary = "rgba(255,255,255,1)",
                Secondary = "rgba(240,99,20,1)",
                Tertiary = "rgba(0,184,228,1)",
                Background = "rgba(242,242,242,1)",
                Surface = "rgba(255,255,255,1)",
                TextPrimary = "rgba(0,0,0,1)",
                TextSecondary = "rgba(255,255,255,1)",
                AppbarBackground = "rgba(255,255,255,1)",
                AppbarText = "rgba(0,0,0,1)"
            },

            PaletteDark = new PaletteDark()
            {
                Primary = "#A78BFA",
                Secondary = "#22D3EE",
                Background = "#0B1220",
                Surface = "#111827",
                TextPrimary = "#E5E7EB",
                TextSecondary = "#9CA3AF",
                Error = "#F87171",
                Warning = "#FBBF24",
                Success = "#34D399",
                Info = "#38BDF8",
                AppbarBackground = "#111827",
                AppbarText = "#E5E7EB"
            },

            Typography = new Typography
            {
                Default = new DefaultTypography()
                {
                    FontFamily = ["Industry", "system-ui", "Segoe UI", "Roboto", "Arial", "sans-serif"]
                }
            }
        };
    }
}
