using UnityEngine;
using UnityEngine.SceneManagement;
public class PigWithDog : MonoBehaviour {
	
	void OnCollisionEnter (Collision other)
	{

		if(other.gameObject.tag == "dog")
			SceneManager.LoadScene("gameover");


	}


}
