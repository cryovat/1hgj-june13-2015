﻿using UnityEngine;
using System.Collections;

public class RestartManager : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.R))
	    {
	        Application.LoadLevel(Application.loadedLevel);
	    }
	}
}
