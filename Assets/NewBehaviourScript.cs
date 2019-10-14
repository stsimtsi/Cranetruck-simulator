using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]

public class AxleLoadmasterCargoInfo
{
	public WheelCollider leftWheel;
	public GameObject leftWheelMesh;
	public WheelCollider rightWheel;
	public GameObject rightWheelMesh;
	//Stelios scripting
	//public Transform[] lastixa = new Transform[4];
	//public Transform lastixa;



   //Stelios scripting	
	public bool motor;
	public bool steering;
	
}

public class NewBehaviourScript : MonoBehaviour {
	
  
	public List<AxleLoadmasterCargoInfo> axleInfos;
	public float maxMotorTorgue;
	public float maxSteeringAngle;
	public int rotationY = 180;
	public Transform lastixo1,lastixo2,lastixo3,lastixo4,lastixo5,lastixo6;
	// Use this for initialization
	void Start () {
	
lastixo1 = transform.Find("Wheel.B.R");
lastixo1= lastixo1.Find("Wheel back R");

lastixo2 = transform.Find("Wheel.F.R");
lastixo2= lastixo2.Find("Wheel front R");

lastixo3 = transform.Find("Wheel.M.L");
lastixo3= lastixo3.Find("Wheel medle L");

lastixo4 = transform.Find("Wheel.M.R");
lastixo4= lastixo4.Find("Wheel medle R");

lastixo5 = transform.Find("Wheel.F.L");
lastixo5= lastixo5.Find("Wheel front L");

lastixo6 = transform.Find("Wheel.B.L");
lastixo6= lastixo6.Find("Wheel back L");
	
	}
	
	// Update is called once per frame
	void Update () {


	
	///Stelios scripting
			if(Input.GetKey(KeyCode.W)){
			lastixo1.Rotate(-80*Time.deltaTime,0,0);
			lastixo2.Rotate(-80*Time.deltaTime,0,0); 
			lastixo3.Rotate(-80*Time.deltaTime,0,0); 
			lastixo4.Rotate(-80*Time.deltaTime,0,0); 
			lastixo5.Rotate(-80*Time.deltaTime,0,0); 
			lastixo6.Rotate(-80*Time.deltaTime,0,0); 

           
   		
		}
		
			if(Input.GetKey(KeyCode.S)){
			lastixo1.Rotate(80*Time.deltaTime,0,0);
			lastixo2.Rotate(80*Time.deltaTime,0,0); 
			lastixo3.Rotate(80*Time.deltaTime,0,0); 
			lastixo4.Rotate(80*Time.deltaTime,0,0); 
			lastixo5.Rotate(80*Time.deltaTime,0,0); 
			lastixo6.Rotate(80*Time.deltaTime,0,0); 				
		}
		
		
		if(Input.GetKey(KeyCode.D)){			
if(rotationY < 360){
rotationY += 5;	
			lastixo2.Rotate(0,1,0,Space.World); 
			lastixo5.Rotate(0,1,0, Space.World);	
}			
		}
		
		if(Input.GetKey(KeyCode.A)){				
if(rotationY > 0){	
rotationY -= 5;		
			lastixo2.Rotate(0,-1,0, Space.World); 
			lastixo5.Rotate(0,-1,0, Space.World);
			}
			
		}
	 
			///Stelios scripting
			
	
	
	}


public void ApplyLocalPositionToVisuals( AxleLoadmasterCargoInfo wheelPair)
{
	wheelPair.leftWheelMesh.transform.Rotate(Vector3.right,Time.deltaTime*wheelPair.leftWheel.rpm*10,Space.Self);
	wheelPair.rightWheelMesh.transform.Rotate(Vector3.right,Time.deltaTime*wheelPair.rightWheel.rpm*10,Space.Self);
	
	
}

public void FixedUpdate()
{

	
	float motor = maxMotorTorgue*Input.GetAxis("Vertical");
	float steering = maxSteeringAngle*Input.GetAxis("Horizontal");

	Rigidbody rb=new Rigidbody();
		rb = GetComponent<Rigidbody>();

	foreach (AxleLoadmasterCargoInfo axleInfo in axleInfos)
	{
		if(axleInfo.steering == true){
			axleInfo.leftWheel.steerAngle= steering;
			axleInfo.rightWheel.steerAngle =steering;
			
			
			
			
		}
		
		if (axleInfo.motor == true){
			axleInfo.leftWheel.motorTorque = motor;
			axleInfo.rightWheel.motorTorque = motor;
			
			
			
		}
		if(Input.GetKey(KeyCode.Space)) {
			axleInfo.leftWheel.brakeTorque = 1000000000000;
			axleInfo.rightWheel.brakeTorque = 1000000000000;
			rb.AddForce(-200*rb.velocity);
		}else{
			axleInfo.leftWheel.brakeTorque = 0;
			axleInfo.rightWheel.brakeTorque = 0;
		}
		
		ApplyLocalPositionToVisuals(axleInfo);
	}
	//if(Input.GetKey(KeyCode(Space)))
	//	motor=-maxMotorTorgue*1000*Input.GetAxis("Vertical"));
	
	    
}
}
