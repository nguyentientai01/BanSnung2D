using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {

	// Use this for initialization
	public GameObject fires;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			setfire();


		
	}
	public void setfire(){
		if (Input.GetMouseButton(0)) {
			fires.SetActive(true);

		} else {
			fires.SetActive(false);
		}
	
	}

}
