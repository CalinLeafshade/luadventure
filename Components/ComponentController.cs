using System;

namespace luadventure
{

    public class ComponentController
    {

        private static ComponentController instance;

        public static ComponentController Instance
        {
            get 
            {
                if (instance != null) instance = new ComponentController();
                return instance;
            }
        }

        public ComponentController()
        {

        }
    }
}

