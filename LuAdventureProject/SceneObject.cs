using System;
using System.Collections.Generic;

namespace luadventure.LuAdventureProject
{
	public class SceneObject
	{
		#region Fields

		int x;
		int y;
		int startingRoom;

		#endregion

		#region Properties

		public int StartingRoom
		{
			get
			{
				return startingRoom;
			}
			set
			{
				startingRoom = value;
			}
		}

		public int Y
		{
			get
			{
				return y;
			}
			set
			{
				y = value;
			}
		}

		public int X {
			get 
			{
				return x;
			}
			set 
			{
				x = value;
			}
		}



		#endregion
	}

}

