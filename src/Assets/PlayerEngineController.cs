using UnityEngine;
using System.Collections;

public class PlayerEngineController : MonoBehaviour
{

    public KeyCode ignitionKey = KeyCode.W;
    
    private ParticleSystem _flare;
    private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	void Start ()
	{
        _flare = gameObject.GetComponentInChildren<ParticleSystem>();
	    _rigidbody2D = gameObject.GetComponentInParent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetKey(ignitionKey))
	    {
	        _flare.enableEmission = true;
            _rigidbody2D.AddForceAtPosition(gameObject.transform.parent.up, gameObject.transform.position);
	    }
	    else
	    {
	        _flare.enableEmission = false;
	    } 
	}



    public void OnDrawGizmos()
    {
        var pos = gameObject.transform.position;

        Gizmos.DrawLine(pos, pos + gameObject.transform.up);
    }

    


}
