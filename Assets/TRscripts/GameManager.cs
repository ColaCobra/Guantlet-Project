using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float ActivePlayers = 0;
	private float DeadPlayers = 0;

	public bool P1playing = false;
	GameObject RefPlayer1 = GameObject.Find ("Player1Strength");


	public bool P2playing = false;
	GameObject RefPlayer2 = GameObject.Find ("Player2Magician");

	public bool P3playing = false;
	GameObject RefPlayer3 = GameObject.Find ("Player3Fool");

	public bool P4playing = false;







	//----------Losing Conditions-------------
	public void Player1Lick(){
		DeadPlayers++;
	}
	public void Player2Lick(){
		DeadPlayers++;
	}
	public void Player3Lick(){
		DeadPlayers++;
	}
	public void Player4Lick(){
		DeadPlayers++;
	}
	//-----------------------------------------
	//----------------Losing Event-------------
	void GameOver(){
	}
	//-----------------------------------------



	void Update () {
	
		if (DeadPlayers == ActivePlayers) {
			GameOver();
		}

		//Player Participation
		if(Input.GetButtonDown ("Start_1")){
			RefPlayer1.gameObject.SetActive(true);
		}

	}
}
