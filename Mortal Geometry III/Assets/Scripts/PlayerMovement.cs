using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rB;
	public float fowardForce = 4000f;
	public float sidewaysForce = 500f;



	void FixedUpdate () {

		rB.AddForce (0, 0, fowardForce * Time.deltaTime);

		if (Input.GetKey("d")) {

			rB.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")) {

			rB.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}


	}
}
