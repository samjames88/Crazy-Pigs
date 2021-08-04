using UnityEngine;
public class CreateStones : MonoBehaviour {

	public GameObject prefab_stone;
	float x = -6f, y= 2.5f;

	void Start () {
		for (int iy=0; iy < 4; iy++) 
		{
			for (int ix=0; ix < 8; ix++) 
			{
				Instantiate (prefab_stone, new Vector2 (x, y), Quaternion.identity);
				x += 1.75f;
			}
			y -= 1.78f;
			x -= 14.2f;
		}
	}
	

}
