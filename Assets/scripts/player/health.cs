using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {

	// Use this for initialization
	public Image redbar;
	public Text healthText;
	public int MaxHealth=100;
	public int curentHealth;
	public float TimeDelay = 1f;
	public float m_TimeDelay = 1f;	
	blueBoss blue;


	void Start () {
		curentHealth = MaxHealth;
		blue = FindObjectOfType<blueBoss> ();
	}
	
	// Update is called once per frame
	void Update () {
		updatebar (curentHealth,MaxHealth);



			if (curentHealth < 0) {
				curentHealth = 0;
			} 



	}
	public void updatebar( int curentHealth, int maxHealth){
		redbar.fillAmount = (float)curentHealth / (float)maxHealth;
		healthText.text = curentHealth.ToString(); 
	}


}
