using Events.MainMenu;
using Reactor.API.Attributes;
using Reactor.API.Interfaces.Systems;
using Reactor.API.Logging;
using Reactor.API.Runtime.Patching;
using System;
using UnityEngine;

namespace Distance.TutorialMod
{
	[ModEntryPoint("com.github.reherc/Distance.TutorialMod")]
	public class Mod : MonoBehaviour
	{
		public static Mod Instance;

		public Log Logger { get; private set; }

		public void Initialize(IManager manager)
		{
			Instance = this;

			Logger = LogManager.GetForCurrentAssembly();

			Logger.Info("Hello World from Tutorial Mod !");

			Events.MainMenu.Initialized.Subscribe(OnMainMenuInitialized);

			RuntimePatcher.AutoPatch();
		}

		private void OnMainMenuInitialized(Initialized.Data data)
		{
			Logger.Info("Main menu has been initialized !");
		}
	}
}
