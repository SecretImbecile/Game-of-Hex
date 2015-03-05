using UnityEngine;
using System.Collections;

public class TileGridScript : MonoBehaviour {
	public class TileGrid:GameGridScript.GameGrid<Object>
	{
		private Hashtable grid;
		int sizeX, sizeY;



		//Constructor
		public TileGrid()
		{
			grid = new Hashtable();
		}



		//Add/set tile at position
		public void set(int x, int y, Object obj)
		{
			//update size bounds
			if (x > sizeX)
				sizeX = x;
			if (y > sizeY)
				sizeY = y;

			//Add to hashtable
			GameGridScript.KeyPair key = new GameGridScript.KeyPair (x, y);

			set (key, obj);
		}
		public void set(GameGridScript.KeyPair key, Object obj)
		{
			grid.Add (key, obj);
		}



		//Get a tile
		public Object get(int x, int y)
		{
			GameGridScript.KeyPair key = new GameGridScript.KeyPair (x, y);
			return get(key);
		}
		public Object get(GameGridScript.KeyPair key)
		{
			return (Object)grid[key];
		}
	}
}
