using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	// Use this for initialization
	public float timeDown =0.2f;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		downcoin ();
	}
	public void downcoin(){
		timeDown -= Time.deltaTime;
		if(timeDown > 0){
			transform.position += Vector3.down * 3 * Time.deltaTime; 
		}
	}
}
