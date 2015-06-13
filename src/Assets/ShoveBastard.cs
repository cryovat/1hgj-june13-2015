using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShoveBastard : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	void Start ()
	{
	    _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	    if (Random.Range(0, 100) > 95)
        {
	    
	        var left = Random.Range(0, 1) == 0;
	        var force = Random.Range(0.02f, 0.03f);

            _rigidbody2D.AddForceAtPosition((left ? Vector2.left  : Vector2.right) * force, gameObject.transform.TransformPoint(0, 1, 0));

            Debug.Log("PUSH!");
	    }


	}
}
