using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinLight : MonoBehaviour {

	public float speedSign;

	// Use this for initialization
	void Start () 
	{

		speedSign = 35f;

	}

	// Update is called once per frame
	void Update () 
	{

		transform.Rotate(new Vector3(0,0,15) * Time.deltaTime * speedSign);
	}
}
