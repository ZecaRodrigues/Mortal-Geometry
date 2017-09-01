using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTongue : MonoBehaviour {

										
	public float speed = 10f;

	// Update is called once per frame
	void Update () 
	{


		transform.Translate (Vector3.down * speed * Time.deltaTime);
		//Invoke((transform.Translate (Vector3.up * speed * Time.deltaTime)), 3f);

	
	}
}
