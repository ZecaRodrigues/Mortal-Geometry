using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleLookAt : MonoBehaviour {

	public Transform targetView;
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (targetView);

	}
}
