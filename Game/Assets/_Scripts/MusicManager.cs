using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Start(){
		audioSource = GetComponent<AudioSource> ();

	}

	void OnLevelWasLoaded(int level){
		AudioClip audioClip = levelMusicChangeArray[level];
		if(audioClip){
			audioSource.clip = audioClip;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
