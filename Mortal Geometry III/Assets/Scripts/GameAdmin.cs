using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAdmin : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 3f;

	public void CompleteLevel (){
	
	
	}

	public void EndGame() {

		if (gameHasEnded == false){
		
			gameHasEnded = true;
			Invoke("Restart", restartDelay);

		}


	}

	void Restart(){

		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	
	}
}
