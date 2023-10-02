using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulet : MonoBehaviour {

	// Use this for initialization

	public int speed = 7;
	public  int dameBulet = 20;
	health mau;
	void Start () {
		mau = FindObjectOfType<health> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * speed * Time.deltaTime;
	}
	public void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
			Destroy (gameObject);

			mau.curentHealth -= dameBulet;


		}
	}
}
