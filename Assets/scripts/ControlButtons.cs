using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlButtons : MonoBehaviour {
	
	public Sprite GreenLEFT, RedLEFT, 
	GreenRIGHT, RedRIGHT, 
	GreenUP, RedUP,
	GreenDOWN, RedDOWN, 
	pigLeft, pigRight, pigUp, pigDown, 
	ReStartRED, ReStartBLUE, 
	CloseRED, CloseBLUE;

	public GameObject pig, bomb;

	public static int bomb_count;

	void Start() { bomb_count = 10; }

	void OnMouseDown()
	{
		switch (gameObject.name)
		{
		case "ArrowLeft":
			GetComponent<SpriteRenderer>().sprite = RedLEFT;
			break;
		case "ArrowRight":
			GetComponent<SpriteRenderer>().sprite = RedRIGHT;
			break;
		case "ArrowUp":
			GetComponent<SpriteRenderer>().sprite = RedUP;
			break;
		case "ArrowDown":
			GetComponent<SpriteRenderer>().sprite = RedDOWN;
			break;
		case "CloseButton":
			GetComponent<SpriteRenderer> ().sprite = CloseRED;
			break;
		case "ReStartButton":
 			GetComponent<SpriteRenderer>().sprite = ReStartRED;
			break;

		}
	}

	void OnMouseUp()
	{
		switch (gameObject.name)
		{
		case "ArrowLeft":
			GetComponent<SpriteRenderer>().sprite = GreenLEFT;
			break;
		case "ArrowRight":
			GetComponent<SpriteRenderer>().sprite = GreenRIGHT;
			break;
		case "ArrowUp":
			GetComponent<SpriteRenderer>().sprite = GreenUP;
			break;
		case "ArrowDown":
			GetComponent<SpriteRenderer>().sprite = GreenDOWN;
			break;
		case "CloseButton":
			GetComponent<SpriteRenderer> ().sprite = CloseBLUE;
			break;
		case "ReStartButton":
			GetComponent<SpriteRenderer>().sprite = ReStartBLUE;
			break;
		}
	}

	void OnMouseUpAsButton()
	{
		switch (gameObject.name)
		{
		case "ArrowLeft":
			pig.GetComponent<SpriteRenderer>().sprite = pigLeft;
			if (pig.transform.position.x > -6f)
			pig.transform.position -= new Vector3 (1.75f, 0f, 0f);
			break;
		case "ArrowRight":
			pig.GetComponent<SpriteRenderer>().sprite = pigRight;
			if (pig.transform.position.x < 6f)
			pig.transform.position += new Vector3 (1.75f, 0f, 0f);
			break;
		case "ArrowUp":
			pig.GetComponent<SpriteRenderer>().sprite = pigUp;
			if (pig.transform.position.y < 3f)
			pig.transform.position += new Vector3 (0.2f, 1.75f, 0f);			
			break;
		case "ArrowDown":
			pig.GetComponent<SpriteRenderer>().sprite = pigDown;
			if (pig.transform.position.y > -3f)
			pig.transform.position += new Vector3 (-0.2f, -1.75f, 0f);
			break;
		case "CloseButton":
			GameObject.Find("Click Audio").GetComponent<AudioSource>().Play();
			Application.Quit();
			break;
		case "ReStartButton":
			GameObject.Find("Click Audio").GetComponent<AudioSource>().Play();
			SceneManager.LoadScene("scene");
			break;
		case "BombButton":
			if (bomb_count > 0) 
			{
				Instantiate (bomb, pig.transform.position, Quaternion.identity);
				bomb_count--;
			}
			break;

		}


	}
}
