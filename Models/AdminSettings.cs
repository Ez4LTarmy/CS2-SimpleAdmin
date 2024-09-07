using CS2_SimpleAdmin.Enums;

namespace CS2_SimpleAdmin.Models;

public class AdminSettings(
    bool showPenaltiesOnJoin = true,
    MenuType menuType = MenuType.Dynamic)
{
    public bool ShowPenaltiesOnJoin { get; set; } = showPenaltiesOnJoin;
    public MenuType MenuType { get; set; } = menuType;
}
