using UnityEngine;
using System.Collections;

/*
Ideas to imply
(done!)Reset platfom below moves with platform creation
(done!)nonono If platform is lower than previous it spawns UFO, and flame otherwise 
(done!)modify image with buttons
(done!)esc to menu, not exit
normal background image
*/


public class Reset : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
			Application.LoadLevel(Application.loadedLevel);
	}
}