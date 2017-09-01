using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainTrigger : MonoBehaviour {

	public Rigidbody rBodyCube1;
	public Rigidbody rBodyCube2;
	public Rigidbody rBodyCube3;
	public Rigidbody rBodyCube4;
	public Rigidbody rBodyCube5;
	public Rigidbody rBodyCube6;
	public Rigidbody rBodyCube7;
	public Rigidbody rBodyCube8;
	public Rigidbody rBodyCube9;
	public Rigidbody rBodyCube10;
	public Rigidbody rBodyCube11;
	public Rigidbody rBodyCube12;
	public Rigidbody rBodyCube13;
	public Rigidbody rBodyCube14;
	public Rigidbody rBodyCube15;
	public Rigidbody rBodyCube16;
	public Rigidbody rBodyCube17;
	public Rigidbody rBodyCube18;
	public Rigidbody rBodyCube19;
	public Rigidbody rBodyCube20;
	public Rigidbody rBodyCube21;
	public Rigidbody rBodyCube22;
	public Rigidbody rBodyCube23;
	public Rigidbody rBodyCube24;
	public Rigidbody rBodyCube25;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{

			//mRenderer1.enabled = true;
			rBodyCube1.useGravity = true;
			rBodyCube2.useGravity = true;
			rBodyCube3.useGravity = true;
			rBodyCube4.useGravity = true;
			rBodyCube5.useGravity = true;
			rBodyCube6.useGravity = true;
			rBodyCube7.useGravity = true;
			rBodyCube8.useGravity = true;
			rBodyCube9.useGravity = true;
			rBodyCube10.useGravity = true;
			rBodyCube11.useGravity = true;
			rBodyCube12.useGravity = true;
			rBodyCube13.useGravity = true;
			rBodyCube14.useGravity = true;
			rBodyCube15.useGravity = true;
			rBodyCube16.useGravity = true;
			rBodyCube17.useGravity = true;
			rBodyCube18.useGravity = true;
			rBodyCube19.useGravity = true;
			rBodyCube20.useGravity = true;
			rBodyCube21.useGravity = true;
			rBodyCube22.useGravity = true;
			rBodyCube23.useGravity = true;
			rBodyCube24.useGravity = true;
			rBodyCube25.useGravity = true;

		}
	}
}
