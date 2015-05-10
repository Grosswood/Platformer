using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	public int highScore;

	public void StartGame()
	{
		Application.LoadLevel("MainScene");
	}
	void Awake () 
	{
		 highScore = PlayerPrefs.GetInt("highScore");
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey("escape"))
			Application.Quit();
	}
}
