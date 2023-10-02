using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedestroy : MonoBehaviour {

	// Use this for initialization
	public int time =2;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		destroy ();
		
	}
	public void destroy(){
		Destroy (gameObject, time);
	}
}
