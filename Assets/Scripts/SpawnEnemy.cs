using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	
	public Transform spawnEnemy;
	public GameObject ufo;
		
	// Use this for initialization
	void Start () {
		
		Spawn();
	}
	
	void Spawn()
	{
		if (Random.Range (0,4) < 1)
		{
			//Instantiate(ufo, SpawnEnemy.position, Quaternion.identity);
		}

	}
	

}
