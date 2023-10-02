using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour {

	// Use this for initialization
	controler ctrl;
	public GameObject Themboom;
	public float boomDelay = 5f;
	public float m_boomDelay;

	void Start () {
		ctrl = FindObjectOfType<controler>();
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	public void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
			ctrl.boom++;
			Destroy (gameObject);
		}
	}
	public void creatBoom(){
		
	}
}
