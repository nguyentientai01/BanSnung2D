using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nịnaBoss : MonoBehaviour {

	// Use this for initialization
	public Animator amin;
	public bool isLeft = true;
	public bool isRight = false;





	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		

	
	

	}
	public void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
			

		
		}


	}
	public void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.CompareTag("Green") || col.gameObject.CompareTag("blue")){}
		amin.SetBool ("attack",false);
		transform.localScale = new Vector3 (0.474f, 0.474f, 0.474f);
		isLeft = false;
	}
	public void OnTriggerStay2D(Collider2D col){
		if(col.gameObject.CompareTag("Green") || col.gameObject.CompareTag("blue")){
			amin.SetBool ("attack",true);

			
			if(isLeft && transform.position.x < col.transform.position.x){
				transform.localScale = new Vector3 (0.474f, 0.474f, 0.474f);
				isLeft = false;
			}
			if(!isLeft && transform.position.x > col.transform.position.x){
				transform.localScale = new Vector3 (-0.474f, 0.474f, 0.474f);
				isLeft = true;
			}


		}
	
	}
	//public void flip(){
	//	if (isLeft) {
			
		//	transform.localScale = new Vector3 (0.474f, 0.474f, 0.474f);
		//	Debug.Log ("dda xoay");



	//	}
	//	if( isLeft == false){
			
	//		transform.localScale = new Vector3 (-0.474f, 0.474f, 0.474f);

		//	isLeft = true;
		//}
	//}




}
