using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {
public Text countText;
public Text winText;
private float count;
	// Use this for initialization
	void Start () {
		count=0;
		
		winText.text= "";
		}
	
	// Update is called once per frame
	void Update () {
		count += Time.deltaTime;
		countText.text= "Time:" + count.ToString();
	}
}
