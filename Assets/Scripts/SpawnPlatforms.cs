using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

	public GameObject platform;
	public GameObject theEnd;
	public GameObject reset;
	public float horizontalMin = 7.5f;
	public float horizontalMax = 14f;

	private float lowerYPosition = 0f;
	private Vector2 originPosition;
	private Vector2 randomPosition;
	
	
	void Start () {
		
		originPosition = transform.position;
		Spawn ();
		
	}
	
	void Spawn()
	{
		// i here is used to define max platforms
		for (int i = 0; i < 20; i++)
		{
			int coinFlip = Random.Range (0,2);
			float yPosition = Random.Range (2f, 6f);
			// y here is either from (2..6) or (-6..-2)
			randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin, horizontalMax), (coinFlip * yPosition + (coinFlip - 1) * yPosition));
			Instantiate(platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
			if (randomPosition.y < lowerYPosition)
				lowerYPosition = randomPosition.y;
		}
		randomPosition = randomPosition + new Vector2 (10f, 3f);
		theEnd.transform.position = randomPosition;
		reset.transform.position = new Vector3 (reset.transform.position.x, lowerYPosition - 3f, reset.transform.position.z);
		//Instantiate(theEnd, randomPosition, Quaternion.identity);
	}
	
}