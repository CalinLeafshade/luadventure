using System;

namespace luadventure
{
	public class AppController
	{
		GUIController guiController;
		
		public AppController ()
		{

		}
		
		public void Start()
		{
			guiController = new GUIController();
			guiController.StartGUI();
		}
	}
}

