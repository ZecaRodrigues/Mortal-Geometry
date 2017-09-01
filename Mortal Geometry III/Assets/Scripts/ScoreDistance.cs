using UnityEngine;
using UnityEngine.UI;

public class ScoreDistance : MonoBehaviour {

	public Transform player;
	public Text scoreDistance;
	
	// Update is called once per frame
	void Update () {
		
		scoreDistance.text = player.position.z.ToString ("0");


	}
}
