using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 pos = new Vector3(0,0,0);
		for (int x=-50; x<50; x++) {
			for (int z=-50; z<50; z++) {
				GameObject hex = (GameObject)Instantiate (Resources.Load ("Hex_0"));
				float height = (2*Mathf.PerlinNoise(x/5f, z/5f)) + (32*Mathf.PerlinNoise(x/50f, z/50f));
				if(z % 2 == 0)
					hex.transform.position = new Vector3(1.8f*x, height, 1.5f*z);
				else
					hex.transform.position = new Vector3((1.8f*x)+0.9f, height, 1.5f*z);
			}
		}
		//Camera.main.transform.position = new Vector3 (pos.x - 4, pos.y +2, pos.z +4);
	
	}


	/**
	 * Sphere coords
	Vector3 GetTilePos(float lon, float lat, int radius){

		float x = (float)radius * Mathf.Cos (lat) * Mathf.Sin (lon);
		float z = (float)radius * Mathf.Sin (lat) * Mathf.Cos (lon);
		float y = (float)radius * Mathf.Cos (lon);

		return new Vector3 (x,y,z);
	}
	*/

	// Update is called once per frame
	void Update () {
		Vector3 current = this.transform.position;
		if (current.y < 1) {
			current.y = 1;
			this.transform.position = current;
		}
	}
}
