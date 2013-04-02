using System;
using Gtk;
using luadventure.LuAdventureProject;
using System.IO;

namespace luadventure
{
	class MainClass
	{
		private static AppController appController;
		
		public static void Main (string[] args)
		{
			Application.Init();
			appController = new AppController();
			appController.Start();
			Application.Run();
		}
	}
}
