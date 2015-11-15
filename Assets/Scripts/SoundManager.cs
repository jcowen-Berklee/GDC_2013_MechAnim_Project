using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayObjectSoundOnce (GameObject thisObject) {

		if (!thisObject.GetComponent<AudioSource>().isPlaying){
			thisObject.GetComponent<AudioSource>().Play();
		}


	}
}
