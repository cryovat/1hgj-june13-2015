using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerKiller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void OnBecameInvisible()
    {
        Debug.Log("DEAD!");

        var got  =GameObject.Find("GameOverText").GetComponent<Text>().enabled = true;

        Destroy(gameObject);
    }
	
	
}
