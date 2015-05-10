using UnityEngine;
using System.Collections;

public class FlameBehavior : MonoBehaviour {

	public float walkSpeed = 5.0f;
	public float fullTime = 0;
	
	private float walkingDirection = 1.2f;
	private Vector3 walkAmount;
	
	// Update is called once per frame
	void Update ()
	{
		walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
		fullTime = fullTime + Time.deltaTime;
		if (fullTime > 1.5)
		{
			walkingDirection = - walkingDirection;
			fullTime = 0;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
		transform.Translate(walkAmount);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		
	}


}
