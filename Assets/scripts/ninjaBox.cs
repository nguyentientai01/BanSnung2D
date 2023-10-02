using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninjaBox : MonoBehaviour {

	// Use this for initialization
	public GameObject Ninja;
	public Animator amin;
	public  float timeDown;
	nịnaBoss n;
	void Start () {
		timeDown = Random.Range (2f, 4.5f);
		n = FindObjectOfType<nịnaBoss> ();
	}
	
	// Update is called once per frame
	void Update () {
		ninjaDown();
	}
	public void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
			


		}
	}

	public  void ninjaDown(){

		float speed = Random.Range (2f,3f);
		timeDown -= Time.deltaTime;
		if(timeDown > 0){
			transform.position += Vector3.down * speed * Time.deltaTime;


		}

	}
}
