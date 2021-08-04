using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour {

	float t;

	void Update () {

		t += Time.deltaTime;

		if (t > 2f)
			SceneManager.LoadScene ("scene");
		
	}
}
