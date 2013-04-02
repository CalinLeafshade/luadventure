using System;

namespace luadventure
{
    public class GUIController
    {
        MainWindow mainWindow;

        public GUIController()
        {

        }

        public void StartGUI()
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}

