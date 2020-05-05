using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel;

	void Start(){
		if(autoLoadNextLevel == 0){
			Debug.Log ("Autoload Disabled");
		}
		else{
			Invoke ("loadNextLevel", autoLoadNextLevel);
		}
	}

	public void LoadLevel(string name){
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void GameOver(string name){
		Debug.Log ("Game Over");
		Application.LoadLevel (name);
		//Destroy (gameObject);
	}

	public void loadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
