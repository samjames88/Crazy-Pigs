using UnityEngine;
using System.Collections;

public class DontDestroyAudio : MonoBehaviour
{

    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("click").Length <= 2)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
    }
}
