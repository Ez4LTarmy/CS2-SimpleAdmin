using CS2_SimpleAdmin.Enums;

namespace CS2_SimpleAdmin.Models;

public class AdminSettings(
    bool showPenaltiesOnJoin = true,
    MenuType menuType = MenuType.Dynamic)
{
    public bool ShowPenaltiesOnJoin { get; set; } = showPenaltiesOnJoin;
    public MenuType MenuType { get; set; } = menuType;
    // private Dictionary<string, object?> SettingsList { get; } = new();

    /*public void SetSetting<T>(string key, T? value)
    {
        SettingsList[key] = value;
    }

    public T? GetSetting<T>(string key, T? defaultValue = default)
    {
        if (!SettingsList.TryGetValue(key, out var value)) return defaultValue;
        
        if (value is T typedValue)
        {
            return typedValue;
        }
        
        throw new InvalidOperationException($"Key '{key}' is not of type {typeof(T)}.");
    }*/
}
