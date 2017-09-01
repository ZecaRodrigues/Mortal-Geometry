using UnityEngine;

public class EndZoneTrigger : MonoBehaviour {

	public GameAdmin gameAdmim;

	void OnTriggerEnter() {

		gameAdmim.CompleteLevel ();
	}

}
