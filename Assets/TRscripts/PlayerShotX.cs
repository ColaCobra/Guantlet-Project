using UnityEngine;
using System.Collections;

public class PlayerShotX : MonoBehaviour {

	public float speed = 15f;




	void Update () 
	{
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	}
}