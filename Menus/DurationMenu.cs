using CounterStrikeSharp.API.Core;

namespace CS2_SimpleAdmin.Menus
{
	public static class DurationMenu
	{
		public static void OpenMenu(CCSPlayerController admin, string menuName, CCSPlayerController? player, Action<CCSPlayerController, CCSPlayerController?, int> onSelectAction)
		{
			var menu = AdminMenu.CreateMenu(menuName);

			foreach (var durationItem in CS2_SimpleAdmin.Instance.Config.MenuConfigs.Durations)
			{
				menu.AddMenuOption(durationItem.Name, (_, _) => { onSelectAction(admin, player, durationItem.Duration); });
			}

			AdminMenu.OpenMenu(admin, menu);
		}
		
		public static void OpenMenu(CCSPlayerController admin, string menuName, string steamId, Action<CCSPlayerController, string, int> onSelectAction)
		{
			var menu = AdminMenu.CreateMenu(menuName);

			foreach (var durationItem in CS2_SimpleAdmin.Instance.Config.MenuConfigs.Durations)
			{
				menu.AddMenuOption(durationItem.Name, (_, _) => { onSelectAction(admin, steamId, durationItem.Duration); });
			}

			AdminMenu.OpenMenu(admin, menu);
		}
	}
}