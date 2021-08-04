using UnityEngine;
using UnityEngine.SceneManagement;
public class BombTimer : MonoBehaviour {

	float t;

	void Update () {
		
		t += Time.deltaTime;

		if (t > 5.5f)
		GetComponent<BoxCollider>().enabled = true;
		
		Destroy (gameObject, 6f);
	}

	void OnCollisionEnter (Collision other)
	{

		if (other.gameObject.tag == "stone")
				Destroy (other.gameObject);

		if (other.gameObject.tag == "dog")
				Destroy (other.gameObject);

		if(other.gameObject.tag == "pig")
			SceneManager.LoadScene("gameover");
		

	}
}
