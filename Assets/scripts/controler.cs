using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controler : MonoBehaviour {

	// Use this for initialization
	public float blueBossDelay = 3f;
	public float m_blueBossDelay ;
	public GameObject blueBoss;
	public int boom = 1;
	public GameObject Themboom;
	public float boomDelay = 5f;
	public float m_boomDelay;
	public GameObject Destroy;
	public float m_GreenBossDelay;
	public float GreenBossDelay = 6f;
	public GameObject GreenBoss;
	public GameObject bullet;
	public float bulletDelay =3f;
	public float m_bulletDelay;
	playerMoving playm;
	public int Coin = 0;
	public Text textCoin;
	public float m_timeDelay = 0f;

	public GameObject Ninja;
	public int soLuongNinja = 3;
	public AudioClip auidoclick;
	public bool isgameOver = false;
	health h;








	void Start () {
		playm = FindObjectOfType<playerMoving> ();
		h = FindObjectOfType<health>();
	




	}
	
	// Update is called once per frame
	void Update () {
		creatBlueBoss ();
		creatGreenBoss ();
		AutocreatBoom ();

		creatBoom ();
		text (Coin);
		setgameOver();


		
	}
	public void creatBlueBoss(){
		m_blueBossDelay -= Time.deltaTime;
		float posy = Random.Range (-3.5f,3f);
		Vector2 pos = new Vector2 (15.5f,posy);
		if(m_blueBossDelay < 0){
			Instantiate (blueBoss,pos,Quaternion.identity);
			m_blueBossDelay = blueBossDelay;
		}
	}
	public void creatGreenBoss(){
		m_GreenBossDelay -= Time.deltaTime;
		float posy = Random.Range (-3.5f,3f);
		Vector2 pos = new Vector2 (15.5f,posy);
		if(m_GreenBossDelay < 0){
			Instantiate (GreenBoss,pos,Quaternion.identity);
			m_GreenBossDelay = GreenBossDelay;
		}
	}
	public void AutocreatBoom(){
		m_boomDelay -= Time.deltaTime;
		if(m_boomDelay <0){
			float posx = Random.Range (-7f,7f);
			Vector2 pos = new Vector2 (posx, 6f);
			Instantiate (Themboom,pos,Quaternion.identity);
			m_boomDelay = boomDelay;
		}
	}
	public void creatBoom(){
		if(Input.GetMouseButton(1) && boom>0){
			Instantiate (Destroy,playm.transform.position,Quaternion.identity);
			boom--;
		}
	}

	public void  text( int c ){
		textCoin.text = c.ToString ();
	}
	public void creatNinja(){
		m_timeDelay -= Time.deltaTime;
		if(m_timeDelay<0 && soLuongNinja > 0 && Coin >= 1){
			float posx = -18.4f;

			Vector2 pos = new Vector2 (posx,0.19f);
			Instantiate (Ninja,pos,Quaternion.identity);
			soLuongNinja -= 1;
			Coin -= 1;


		}

	}
	public void setgameOver(){
		if(h.curentHealth == 0){
      isgameOver = true;
	    Invoke("menuGame",2);
		}
	}
	public void menuGame(){
		Application.LoadLevel ("menugame2");
	}





}
