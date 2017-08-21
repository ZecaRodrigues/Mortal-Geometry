using UnityEngine;

public class DemageForce : MonoBehaviour {

	public Rigidbody rB;
	public PlayerEnergyController player;
	private float demageRate;

	void Start()
	{
		demageRate = rB.mass;

	}

	void OnCollisionEnter(Collision other)
	{

		if (other.collider.tag == "Player"){

			player.energyCurrent -= demageRate;

		}
	}


}
