﻿using UnityEngine;
using System.Collections;

public class Player2 : PlayerMaster {
	
	
	private Vector3 temp;
	
	public bool CanMelee = true;
	public GameObject melee;
	
	public bool CanShoot = true;
	public GameObject shootforward;
	public GameObject shootbackward;
	public GameObject shootleft;
	public GameObject shootright;

	void Awake(){
		GameObject managerObject = GameObject.Find ("GameManager");
		GameManager managerScript = managerObject.GetComponent<GameManager> ();
		managerScript.ActivePlayers++;
	}
	
	

	
	
	
	//------------------------------------------------------
	void MeleeAttack(){
		GameObject shot = Instantiate (melee) as GameObject;
		shot.transform.position = transform.position;
		shot.transform.parent = transform;
		BasicAttackCooldown = Time.time + 0.25f;
	}
	
	void ShootAttack(){
		GameObject forward = Instantiate (shootforward) as GameObject;
		forward.transform.position = transform.position;
		
		GameObject backward = Instantiate (shootbackward) as GameObject;
		backward.transform.position = transform.position;
		
		GameObject left = Instantiate (shootleft) as GameObject;
		left.transform.position = transform.position;
		
		GameObject right = Instantiate (shootright) as GameObject;
		right.transform.position = transform.position;
		
		BasicAttackCooldown = Time.time + 0.25f;
	}
	
	void BleedHealth(){
		playerHealth--;
		BleedTimer = Time.time + 5;
	}
	
	//------------------------------------------------------
	void Update () {
		
		//Basic Attack
		if(Input.GetButtonDown ("X_2") && CanMelee == true)
		{
			if (BasicAttackCooldown <= Time.time){
				MeleeAttack();
			}
		}
		
		if(Input.GetButtonDown ("Y_2") && CanShoot == true)
		{
			if (BasicAttackCooldown <= Time.time){
				ShootAttack();
			}
		}
		
		//Bleed Effect
		if (BleedTimer <= Time.time){
			BleedHealth();
		}
	}
	
	
	
	
	
	void FixedUpdate () {

		if (playerHealth > playerHealthMax) {
			playerHealth = playerHealthMax;
		}
		
		if (playerHealth < 0) {
			GameObject managerObject = GameObject.Find ("GameManager");
			GameManager managerScript = managerObject.GetComponent<GameManager> ();
			managerScript.Player2Lick ();
		}
		
		
		if (Input.GetAxis ("L_XAxis_2") > 0.2) {
			//move character right
			temp = this.transform.position;
			temp.x += playerSpeed;
			this.transform.position = temp;
		}
		if (Input.GetAxis ("L_XAxis_2") < -0.2) {
			//move character left
			temp = this.transform.position;
			temp.x -= playerSpeed;
			this.transform.position = temp;
		}
		if (Input.GetAxis ("L_YAxis_2") < -0.2) {
			//move character up
			temp = this.transform.position;
			temp.z += playerSpeed;
			this.transform.position = temp;
		}
		if (Input.GetAxis ("L_YAxis_2") > 0.2) {
			//move character down
			temp = this.transform.position;
			temp.z -= playerSpeed;
			this.transform.position = temp;
		}
		
	}
}

