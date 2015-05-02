using UnityEngine;
using System.Collections;

public class PlayerShotZ : MonoBehaviour {
	
	public float speed = 15f;
	
	
	
	
	void Update () 
	{
		Vector3 pos = transform.position;
		pos.z += speed * Time.deltaTime;
		transform.position = pos;
	}
}