using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoving : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	public float Trai_Phai;
	public float Tren_Duoi;
	public int tocDo= 5;
	public int tocDoRun = 20;
	public float runTime =2f;
	public float m_runTime =2f;

	public float timeDash;
	public float m_timeDash;
	public bool isRunning = false;
	public float TimeDelay = 0.02f;
	public float m_TimeDelay;
	public GameObject matorial;
	public GameObject matorialLeft;
	public Animator amin;
	public AudioSource aus;
	

	public AudioClip audioCoin;
	public AudioClip audioHp;
	health mau;

	controler ctrl;


	public SpriteRenderer character;
	void Start () {
		
		ctrl = FindObjectOfType<controler> ();
		mau = FindObjectOfType<health> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		Trai_Phai = Input.GetAxisRaw ("Horizontal");
		Tren_Duoi = Input.GetAxisRaw ("Vertical");
		rb.velocity = new Vector2 (Trai_Phai* tocDo,rb.velocity.y);
		rb.velocity = new Vector2 (rb.velocity.x, tocDo * Tren_Duoi);
		//tạo chuyển động xoay người khi nhấn phím trái phải
		xoaynguoi ();

		run();
		//animation
		walkamin();
		attackamin ();
		dieamin ();
		



	}
	public void xoaynguoi(){
		if (Trai_Phai > 0) {
			character.transform.localScale = new Vector3 (0.79f, 0.79f, 0f);
		}
		if (Trai_Phai < 0) {
			character.transform.localScale = new Vector3 (-0.79f,0.79f,0);
		}

	}
	public void walkamin(){
		amin.SetFloat ("walk", Mathf.Abs (Trai_Phai));
		
	}
	public void attackamin(){
		if (Input.GetMouseButton(0)) {
			amin.SetBool ("attack", true);
		} else {
			amin.SetBool ("attack",false);
		}

	}
	public void run(){
		if (Input.GetKeyDown (KeyCode.Space) && m_timeDash < 0 && isRunning == false) {
			tocDo += tocDoRun;
			m_timeDash = timeDash;
			isRunning = true;
			if (Trai_Phai >= 0) {
				creatmatorialRight ();
			} else {
				creatmatorialLeft ();
			}
		}
		if (isRunning == true && m_timeDash < 0) {
			tocDo -= tocDoRun;
			isRunning = false;
		} else {
			m_timeDash -= Time.deltaTime;
		}
	}
	public void creatmatorialRight(){
		TimeDelay -= Time.deltaTime;
		if (m_TimeDelay < 0)
			Instantiate (matorial, transform.position, Quaternion.identity);
		m_TimeDelay = TimeDelay;
	}
	public void creatmatorialLeft(){
		TimeDelay -= Time.deltaTime;
		if(m_TimeDelay < 0){
			Instantiate (matorialLeft, transform.position, Quaternion.identity);
			m_TimeDelay = TimeDelay;
		}
	}
	public void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("coin")){
			Destroy(col.gameObject);
			ctrl.Coin += 1;
			aus.PlayOneShot (audioCoin);
		}
		if(col.gameObject.CompareTag("Hp")){
            if(mau.curentHealth < 100){
                Destroy(col.gameObject);
			 mau.curentHealth += 5;
			 aus.PlayOneShot(audioHp);
			}
		}
	}
	public void dieamin(){
		if (mau.curentHealth == 0) {
			amin.SetBool ("die",true);

		}
	}


		



	}
	


		
	

