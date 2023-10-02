using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerAtack : MonoBehaviour {

	// Use this for initialization

	public GameObject Attack;
	public float TimeDelay = 0.2f;
	public float m_timeDelay;
	public float speed = 14f;
	public Rigidbody2D rb;
	public Transform head;
	public float x = 145f ;



	void Start () {
		
		Vector3 temp = transform.position;
		temp.x += 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
		m_timeDelay -= Time.deltaTime;
		if (m_timeDelay < 0 && Input.GetMouseButton(0) ) {
			creatAttack ();
		}
		rotate ();


	}

	public void creatAttack(){
		GameObject attack= Instantiate (Attack,head.transform.position,Quaternion.identity);
	Rigidbody2D rb = attack.GetComponent<Rigidbody2D>();

		rb.AddForce (transform.right * speed,ForceMode2D.Impulse);
		m_timeDelay = TimeDelay;
	}
	public void rotate(){
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		Vector3 lookDir = mousePos - transform.position;

		float angle = Mathf.Atan2 (lookDir.y,lookDir.x) * Mathf.Rad2Deg + x;
		Quaternion rotation = Quaternion.Euler (0, 0, angle);

		transform.rotation = rotation;
		if (transform.eulerAngles.z > 90f && transform.eulerAngles.z < 270f) {
			transform.localScale = new Vector3 (1, -1, 0);
		} else {
			transform.localScale = new Vector3 (1, 1, 0);
		}
	
	}
}
