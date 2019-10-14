using UnityEngine;
using System.Collections;

public class upAndDown : MonoBehaviour {
 float speed= 0.03f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.DownArrow)){
			transform.Rotate(speed,0,0);
			
		}
		else{
			transform.Rotate(0,0,0);
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Rotate(-speed,0,0);
			
		}
		else{
			transform.Rotate(0,0,0);
		}
	}
}
