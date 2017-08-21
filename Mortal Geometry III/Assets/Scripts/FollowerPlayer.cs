using UnityEngine;
using System.Collections;

public class FollowerPlayer : MonoBehaviour {

	private Transform player;
	private Vector3 offset;
	private Vector3 moveVector;

	private float transition = 0.0f;
	private float animationDuration = 1.0f;
	private Vector3 animationOffset = new Vector3 (0, 5, -14);

	void Start() {

		player = GameObject.FindGameObjectWithTag ("Player").transform;
		offset = transform.position - player.position;
	}

	void Update () {

		moveVector = player.position + offset;

		moveVector.x = Mathf.Clamp (moveVector.x, -7f, 7f);
		moveVector.y = Mathf.Clamp (moveVector.y, 3f, 20f);

		if (transition > 1.0f) {

			transform.position = moveVector;
		} else {
			
			transform.position = Vector3.Lerp (moveVector + animationOffset, moveVector, transition);
			transition += Time.deltaTime * 1 / animationDuration;
			transform.LookAt (player.position + Vector3.up);

		}
	}
}
