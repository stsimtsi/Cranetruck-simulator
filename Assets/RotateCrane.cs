﻿using UnityEngine;
using System.Collections;

public class RotateCrane : MonoBehaviour {
	
	 float speed= 0.03f;
	

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)){
			
			transform.Rotate(0,speed,0);
			
		}
		else{
			transform.Rotate(0,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			
			transform.Rotate(0,-speed,0);
			
		}
		else{
			transform.Rotate(0,0,0);
		}
	
	}
}
