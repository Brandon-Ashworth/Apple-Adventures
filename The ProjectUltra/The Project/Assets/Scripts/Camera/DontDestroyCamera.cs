﻿using UnityEngine;
using System.Collections;

public class DontDestroyCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (transform.gameObject);
	}
}
