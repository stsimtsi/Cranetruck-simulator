using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinBox : MonoBehaviour 
{
	public Text timerText;
	public GameObject cube;
	public Text result;
	public Text final;
	float score;
	float min;
	string minutes;


private float startTime;
private bool finished=false;
	// Use this for initialization
	void Start () {
	startTime=Time.time;
result.text= "";
final.text="";	
	}
	
	// Update is called once per frame
	void Update () {
	if(finished)
	return;
	
	
	
	float t= Time.time-startTime;
    min += Time.deltaTime;
		minutes =((int) t/60).ToString();
	string	seconds =(t% 60).ToString("f2");
	timerText.text="Time: "+ minutes + ":" + seconds;
	}
	
	private void OnTriggerEnter(Collider other){ 
	if (other.gameObject.tag == "trap"){ 
	
        Debug.Log("Yay!");
    timerText.color=Color.yellow; 
	finished=true;
	float distance = Vector3.Distance (other.gameObject.transform.position, cube.transform.position);
	result.text="Distance: "+ distance.ToString();
	score= (1000-min) - (distance*10);
	final.text= "Your Score: "+ score.ToString();
	//GameObject.Find("skata").SendMessage("Finnish");
	}
	}
	
} 
