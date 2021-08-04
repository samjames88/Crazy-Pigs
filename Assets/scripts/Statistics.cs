using UnityEngine;
using UnityEngine.UI;
public class Statistics : MonoBehaviour {

	public Text bomb_txt, timer_txt, dogs_txt;
	float timer;

	void Update () {
		
		if (GameObject.FindGameObjectsWithTag("stone").Length >= 1)
		timer += Time.deltaTime;
		
		timer_txt.text = "Timer " + timer.ToString("f1") + " s";
		bomb_txt.text = "Bombs " + ControlButtons.bomb_count.ToString ();
		dogs_txt.text = "Dogs " + GameObject.FindGameObjectsWithTag ("dog").Length.ToString ();
		
	}
}
