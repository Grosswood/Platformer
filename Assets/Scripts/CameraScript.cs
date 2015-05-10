using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public bool paused = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI ()
	{
		if (GUI.Button (new Rect (Screen.width/15, Screen.height/15, Screen.width / 8, Screen.height / 8), "Pause"))
		{
			// timeScale: 1 >> 0 ; 0 >> 1
			Time.timeScale = 1 - Time.timeScale;
			paused = !paused;
		}
	}
}
