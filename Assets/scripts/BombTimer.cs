using UnityEngine;
public class BombTimer : MonoBehaviour {
	void Update () {
		Destroy (gameObject, 6f);
	}
}
