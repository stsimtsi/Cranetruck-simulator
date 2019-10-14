using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCrane:MonoBehaviour {
 
// GameObject part;
 public GameObject rope;
 public CapsuleCollider lala;
	// Use this for initialization
	
	 void OnCollisionStay(Collision col){
		 print("Col");
        if(col.gameObject.tag == "Part") 
        {
			if(Input.GetKey(KeyCode.F)){
			
			
			
            col.gameObject.transform.parent = lala.transform;
			col.gameObject.transform.localPosition= new Vector3(106,90,-174);
			
			//col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			Destroy (col.gameObject.GetComponent<Rigidbody>());
			
			GameObject part=col.gameObject;
			
			
			//Destroy(col.gameObject);
        }
		}
		
		
    }
	void lalala(){
		if(Input.GetKey(KeyCode.Keypad4)){
			GameObject part = rope.transform.GetChild(0).gameObject;
			part.transform.parent = null;
           //rope.transform.DetachChildren();
			//col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			Rigidbody gameObjectsRigidBody = part.AddComponent<Rigidbody>(); // Add the rigidbody.
            gameObjectsRigidBody.mass = 1; // Set the GO's mass to 5 via the Rigidbody.
			}
		
	}
	
}
