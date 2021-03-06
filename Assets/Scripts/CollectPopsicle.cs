using UnityEngine;
using System.Collections;


/// <summary>
/// Collects popsicle. And tell spawner to create bears
/// </summary>
public class CollectPopsicle : MonoBehaviour {
	
	public GameObject Spawner;

	SoundManager mySound;

	void Start (){
		GameObject myNewSounds = GameObject.Find("AudioObject");
		mySound = myNewSounds.GetComponent<SoundManager>();
	}
	
	void DoCollect(Collider collider)
	{
		if(!enabled) return;
		
		if(collider.gameObject.tag == "Player")
		{
			mySound.PlayObjectSoundOnce(this.gameObject);

//			if (!GetComponent<AudioSource>().isPlaying){
//				GetComponent<AudioSource>().Play();
//			}
			Destroy(gameObject,GetComponent<AudioSource>().clip.length);
			
			Spawner.GetComponent<Spawner>().BeginSpawning();
		}
	}
	
	void OnTriggerStay(Collider collider)
	{
		DoCollect (collider);
	}
	
	void OnTriggerEnter(Collider collider)
	{
		DoCollect (collider);
	}
}
