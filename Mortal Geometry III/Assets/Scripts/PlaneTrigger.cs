using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour {


	public Rigidbody rBodyCube1;
	public Rigidbody rBodyCube2;
	public Rigidbody rBodyCube3;
	public Rigidbody rBodyCube4;
	public Rigidbody rBodyCube5;
	public Rigidbody rBodyCube6;

	//public MeshRenderer mRenderer1;
	//public MeshRenderer mRenderer2;
	//public MeshRenderer mRenderer3;
	//public MeshRenderer mRenderer4;
	//public MeshRenderer mRenderer5;
	//public MeshRenderer mRenderer6;

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

			//mRenderer2.enabled = true;
			rBodyCube2.useGravity = true;

			//mRenderer3.enabled = true;
			rBodyCube3.useGravity = true;

			//mRenderer4.enabled = true;
			rBodyCube4.useGravity = true;

			//mRenderer5.enabled = true;
			rBodyCube5.useGravity = true;

			//mRenderer6.enabled = true;
			rBodyCube6.useGravity = true;
		}
	}
}
