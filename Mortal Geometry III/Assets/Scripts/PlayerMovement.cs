using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	//private Rigidbody rBody;
	public float fowardForce = 4000f;
	public float sidewaysForce = 500f;

	public Rigidbody rB;
	public Transform targetView;


	void Start () {

	//	rBody = GetComponent<Rigidbody> ();


	}

	void FixedUpdate () {

	//	rBody.AddForce (0, 0, fowardForce * Time.deltaTime);

	//	float inputX = Input.GetAxis ("Horizontal");
	//	float inputZ = Input.GetAxis ("Vertical");

	//	float moveX = inputX * fowardForce * Time.deltaTime;
	//	float moveZ = inputZ * sidewaysForce * Time.deltaTime;

	//	rBody.AddForce(moveX, 0f, moveZ);






		rB.AddForce (0, 0, fowardForce * Time.deltaTime);
	
		if (Input.GetKey("d")) {

			rB.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")) {

			rB.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rB.position.y < -1f) {
		
			FindObjectOfType<GameAdmin> ().EndGame ();
		
		}

		transform.LookAt (targetView);


	}
}
