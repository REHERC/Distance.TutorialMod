using Centrifuge.Distance.Data;
using Centrifuge.Distance.Game;
using HarmonyLib;

namespace Distance.TutorialMod.Harmony
{
	[HarmonyPatch(typeof(MainMenuLogic), "OnOptionsClicked")]
	internal static class MainMenuLogic__OnOptionsClicked
	{
		[HarmonyPostfix]
		internal static void Postfix(MainMenuLogic __instance)
		{
			MessageBox.Create("Options was clicked", "TUTORIAL MOD")
				.SetButtons(MessageButtons.Ok)
				.OnConfirm(() =>
				{
					Mod.Instance.Logger.Info("Ok button was clicked !");
				})
				.Show();
		}
	}
}
