using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("blue")){
			
			Debug.Log("tài");
		}
	}
}
