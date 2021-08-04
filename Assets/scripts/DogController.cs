using UnityEngine;
public class DogController : MonoBehaviour {
	int rand;
	float t;
	public Sprite dogLeft, dogRight, dogUp, dogDown;

	void Start () {
		rand = Random.Range (1,5);
	}
	

	void Update () {
		
		t += Time.deltaTime;

		if (t > 2f) 
		{
			switch (rand) 
			{
			case 1: 
				GetComponent<SpriteRenderer>().sprite = dogLeft;
				if (transform.position.x > -6f)
					transform.position -= new Vector3 (1.75f, 0f, 0f);
				break;

			case 2: 
				GetComponent<SpriteRenderer>().sprite = dogRight;
				if (transform.position.x < 6f)
					transform.position += new Vector3 (1.75f, 0f, 0f);
				break;

			case 3: 
				GetComponent<SpriteRenderer>().sprite = dogUp;
				if (transform.position.y < 3f)
					transform.position += new Vector3 (0.2f, 1.75f, 0f);
				break;

			case 4: 
				GetComponent<SpriteRenderer>().sprite = dogDown;
				if (transform.position.y > -3f)
					transform.position += new Vector3 (-0.2f, -1.75f, 0f);
				break;
			}

			t = 0f;
			Start ();
		}
		
	}
}
