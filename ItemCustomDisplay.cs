// The NiTiS-Dev licenses this file to you under the MIT license.

using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WingsAndHookStatsPlusPlus.Common.Configs;
using static WingsAndHookStatsPlusPlus.WaHSpp;

namespace WingsAndHookStatsPlusPlus;
public class ItemCustomDisplay : GlobalItem
{
	public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
	{
		WaHSppConfig config = GetConfig();


		// Wings stats
		sbyte wingsID = item.wingSlot;
		if (wingsID != -1 && config.EnableWingsStats)
		{
			WingStats wingStats = ArmorIDs.Wing.Sets.Stats[wingsID];
			float flyTime = wingStats.FlyTime / 60f;
			string line1 = Language.GetTextValue("Mods.WaHSpp.GenericTooltip.Wings.FlightTime", flyTime.ToString("0.##"));
			string line2 = Language.GetTextValue("Mods.WaHSpp.GenericTooltip.Wings.HorizontalSpeed", wingStats.AccRunSpeedOverride.ToString("~0.##"));
			string line3 = Language.GetTextValue("Mods.WaHSpp.GenericTooltip.Wings.VerticalSpeedMul", wingStats.AccRunAccelerationMult.ToString("~0.##"));
			tooltips.Add(new(Mod, WingsSort, "\n" + Language.GetTextValue("Mods.WaHSpp.GenericTooltip.Wings.Header"))
			{
				OverrideColor = config.WingsStatsHeaderColor
			});
			tooltips.Add(new(Mod, WingsSort, line1));
			tooltips.Add(new(Mod, WingsSort, line2));
			tooltips.Add(new(Mod, WingsSort, line3));
			if (wingStats.HasDownHoverStats)
			{
				//TODO: Hover stats
			}
			return;
		}


		// Hooks stats
		float hookSpeed = System.Single.NegativeInfinity;
		if (item.shoot != ProjectileID.None)
		{
			ModProjectile projectile = ModContent.GetModProjectile(item.shoot);
			if (projectile == null) return;
			projectile.GrapplePullSpeed(Main.CurrentPlayer, ref hookSpeed);
			if (hookSpeed == System.Single.NegativeInfinity) return;
			string line1 = Language.GetTextValue("Mods.WaHSpp.GenericTooltip.Hooks.GrapSpeed", hookSpeed);
			tooltips.Add(new(Mod, HooksSort, "\n" + Language.GetTextValue("Mods.WaHSpp.GenericTooltip.Hooks.Header"))
			{
				OverrideColor = config.HookStatsHeaderColor
			});
			tooltips.Add(new(Mod, HooksSort, line1));
		}


		return;
	}
}