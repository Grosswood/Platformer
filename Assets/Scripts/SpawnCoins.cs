using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

	public Transform[] coinSpawns;
	public GameObject coin;
	public Transform FlameSpawn;
	public Transform UFOSpawn;
	public GameObject flame;
	public GameObject ufo;


	// Use this for initialization
	void Start () {
	
		Spawn();
	}

	void Spawn()
	{
		for (int i = 0; i < coinSpawns.Length; i++)
		{
			int coinFlip = Random.Range (0,2);
			if (coinFlip > 0)
			{
				Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
			}
		}

		int spawnOrNot = Random.Range (0, 2);
		if (spawnOrNot == 0)
		{
			Instantiate(flame, FlameSpawn.position, Quaternion.identity);
		}
		if (spawnOrNot == 1)
		{
			Instantiate(ufo, UFOSpawn.position, Quaternion.identity);
		}
	}
	

}
