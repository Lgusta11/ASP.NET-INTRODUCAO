using MudBlazor;
using MudBlazor.Utilities;

namespace ScreenSound.Web.Layout;

public sealed class ScreendsoundPallete : PaletteDark
{
    private ScreendsoundPallete()
    {
        Primary = new MudColor("#8855FF"); // Um tom mais escuro de roxo
        Secondary = new MudColor("#F6B831"); // Um tom mais escuro de laranja
        Tertiary = new MudColor("#8AE4A1"); // Um tom mais claro de verde
    }

    public static ScreendsoundPallete CreatePallete => new();
}
