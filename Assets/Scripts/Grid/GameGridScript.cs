using UnityEngine;
using System.Collections;

public class GameGridScript : MonoBehaviour {
	public abstract class GameGrid<type>
	{
		private Hashtable grid;
	}

	public class KeyPair
	{
		public int x;
		public int y;

		public KeyPair(int xIn, int yIn)
		{
			x = xIn;
			y = yIn;
		}
	}
}
