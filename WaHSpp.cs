using Terraria.ModLoader;
using WingsAndHookStatsPlusPlus.Common.Configs;

namespace WingsAndHookStatsPlusPlus;

public class WaHSpp : Mod
{
	public const string WingsSort = "WingsStats";
	public const string HooksSort = "HookStats";
	public static WaHSppConfig GetConfig()
		=> ModContent.GetInstance<WaHSppConfig>();
}