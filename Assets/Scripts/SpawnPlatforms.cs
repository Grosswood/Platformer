using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {
	
	public int maxPlatforms = 20;
	public GameObject platform;
	public float horizontalMin = 7.5f;
	public float horizontalMax = 14f;
	public float verticalMin = 2f;
	public float verticalMax = 6f;
	
	
	private Vector2 originPosition;
	
	
	void Start () {
		
		originPosition = transform.position;
		Spawn ();
		
	}
	
	void Spawn()
	{
		int coinFlip = Random.Range (0,2);
		float yPosition = Random.Range (verticalMin, verticalMax);
		for (int i = 0; i < maxPlatforms; i++)
		{
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin, horizontalMax), (coinFlip * yPosition + (coinFlip - 1) * yPosition));
			Instantiate(platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
	}
	
}