using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueBoss : MonoBehaviour {
	
	public float speed = 3.2f;
	public int Hp = 5;
	public int Dameblue = 10;
	public bool isblueAttack = false;
	health mau;
	public GameObject explode;
	public GameObject smoke;
	public AudioClip audioattack;
	playerMoving plv;
	public AudioClip audiodie;
	public GameObject ThemHp;



	// Use this for initialization
	void Start () {
		mau = FindObjectOfType<health> ();
		plv = FindObjectOfType<playerMoving> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		autoWalk ();


	}
	public void autoWalk(){
		transform.position += Vector3.left * speed * Time.deltaTime;
	}
	public void OnTriggerEnter2D(Collider2D col){
		
		if(col.gameObject.CompareTag("ball")){
			Hp -= 1;
			plv.aus.PlayOneShot (audioattack);
			GameObject Smoke =	Instantiate (smoke,transform.position,Quaternion.identity);
			Destroy(Smoke, 0.5f);
			Destroy (col.gameObject);
			if( Hp == 0){

			GameObject themhp	= Instantiate(ThemHp,transform.position,Quaternion.identity);
			Destroy(themhp,3f);
				
				
				plv.aus.PlayOneShot (audiodie );
				
				Destroy (gameObject);
				GameObject x =	Instantiate (explode,transform.position,Quaternion.identity);
				Destroy (x, 0.2f);
				

			}
		}
		if(col.gameObject.CompareTag("Player")){
			isblueAttack = true;
			Destroy (gameObject);
			GameObject x =	Instantiate (explode,transform.position,Quaternion.identity);
			Destroy (x, 0.2f);

			mau.curentHealth -= Dameblue;
		}
		if(col.gameObject.CompareTag("Destroy")){
			Destroy (col.gameObject);
			Destroy (gameObject);
			GameObject x =	Instantiate (explode,transform.position,Quaternion.identity);
			Destroy (x, 0.2f);
		}
	}
	


}
