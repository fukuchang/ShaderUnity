﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0f, 1.0f, 0f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0f, -1.0f, 0f);
		}
	}
}
