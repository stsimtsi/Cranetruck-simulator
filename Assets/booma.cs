using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booma : MonoBehaviour {
 float speed= 0.007f;
 float counter= 0;
	// Use this for initialization
	void Start () {
	//start_counter=transform.position.x;	
	}
	
	// Update is called once per frame
	void Update () {
	print(counter);
	if(Input.GetKey(KeyCode.RightShift)){
	
	if(counter < 1400){
	transform.Translate(speed,0,0);
	counter ++;
}
		}
	if(Input.GetKey(KeyCode.RightControl)){
	if(counter > -1){
		transform.Translate(-speed,0,0);
		counter --;
		}
	}
	print(counter);
	}
}
