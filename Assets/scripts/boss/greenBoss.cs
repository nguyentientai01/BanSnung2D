using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenBoss : MonoBehaviour {

	// Use this for initialization
	public float speed = 2.5f;
	public int Hp= 30;
	public GameObject creatCoin;
	public GameObject Explode;
	public GameObject smoke;
	public GameObject Fire;
	health mau;
	playerMoving plv;

	public AudioClip audioattack;
	public AudioClip audiodie;

	void Start () {
		mau = FindObjectOfType<health> ();
		plv = FindObjectOfType<playerMoving> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * speed * Time.deltaTime;
		
	}
	public void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("ball")){
			plv.aus.PlayOneShot (audioattack);
			Hp -= 1;
			Destroy (col.gameObject);
			if(Hp <= 20 && Hp >10){
				GameObject Smoke =	Instantiate (smoke,col.transform.position,Quaternion.identity);
				Destroy(Smoke, 1f);
			}
			if(Hp <= 10){
				GameObject fire =	Instantiate (Fire,transform.position,Quaternion.identity);
				Destroy(fire, 0.5f);
			}
			if( Hp == 0){
				plv.aus.PlayOneShot (audiodie );

				Destroy (gameObject);
				Instantiate (creatCoin, transform.position, Quaternion.identity);
				GameObject x =	Instantiate (Explode,transform.position,Quaternion.identity);
				Destroy (x, 0.2f);

			}
		}
		if(col.gameObject.CompareTag("Player")){
			
			Destroy (gameObject);
			GameObject x =	Instantiate (Explode,transform.position,Quaternion.identity);
			Destroy (x, 0.2f);
		
			mau.curentHealth -= 50;

		}
		if(col.gameObject.CompareTag("Destroy")){
			Destroy (col.gameObject);
			Destroy (gameObject);
			Instantiate (creatCoin, transform.position, Quaternion.identity);
			GameObject x =	Instantiate (Explode,transform.position,Quaternion.identity);
			Destroy (x, 0.2f);

		}
	}
}
