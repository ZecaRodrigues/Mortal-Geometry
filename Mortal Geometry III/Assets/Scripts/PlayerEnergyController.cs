using System.Collections;
using UnityEngine;

public class PlayerEnergyController : MonoBehaviour {

	public float energyMax = 1f;
	public float energyCurrent = 0f;

	public PlayerMovement movement;

	void Start () {

		energyCurrent = energyMax;

	}

	void Update () {

		if(energyCurrent <= 0)
		{
			movement.enabled = false;
			FindObjectOfType<GameAdmin> ().EndGame();

		}
			
		GetComponent<MeshRenderer> ().material.color = new Color (GetComponent<MeshRenderer> ().material.color.r, GetComponent<MeshRenderer> ().material.color.g, GetComponent<MeshRenderer> ().material.color.b, energyCurrent);

	}
}
