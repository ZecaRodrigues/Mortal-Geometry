using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWheelRotation1 : MonoBehaviour {

	public float speedSign;

	// Use this for initialization
	void Start () 
	{

		speedSign = 20f;

	}

	// Update is called once per frame
	void Update () 
	{

		transform.Rotate(new Vector3(0,15,0) * Time.deltaTime * speedSign);
	}
}
