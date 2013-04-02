using System;
using System.Collections.Generic;

namespace luadventure.LuAdventureProject
{
	public class Room
	{
        #region Fields

        int id;
        string name;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        #endregion
	}

}

