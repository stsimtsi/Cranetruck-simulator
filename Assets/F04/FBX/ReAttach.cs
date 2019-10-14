using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReAttach : MonoBehaviour {
public GameObject obj;
public GameObject thi;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.C)){
			transform.parent=obj.transform;
			//transform.DetachChildren();
			Rigidbody gameObjectsRigidBody = thi.AddComponent<Rigidbody>(); // Add the rigidbody.
           // gameObjectsRigidBody.mass = 1;
		}
	}
}
