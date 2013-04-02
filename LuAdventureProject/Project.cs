using System;
using System.Collections.Generic;

namespace luadventure.LuAdventureProject
{
	[Serializable]
	public class Project
	{

		#region Fields

		string projectRoot = "";
		List<SceneObject> sceneObjects = new List<SceneObject>();
		List<Room> rooms = new List<Room>();
		string name = "lol";

		#endregion
		
		#region Properties

		[NonLuaSerialized]
		public string ProjectRoot
		{
			get
			{
				return projectRoot;
			}
			set
			{
				projectRoot = value;
			}
		}

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

		public List<SceneObject> SceneObjects
		{
			get
			{
				return sceneObjects;
			}
			set
			{
				sceneObjects = value;
			}
		}

		public List<Room> Rooms
		{
			get
			{
				return rooms;
			}
			set
			{
				rooms = value;
			}
		}			
		
		#endregion

		public Project ()
		{
			
		}
		
		
	}
}

