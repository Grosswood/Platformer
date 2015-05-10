using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {

	public float fallDelay = 1f;

	private Rigidbody2D rb2d;
	private BoxCollider2D bc2d;
	private Renderer rend;

	// Use this for initialization
	void Awake ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		bc2d = GetComponent<BoxCollider2D> ();
		rend = GetComponent<Renderer> ();

	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
			Invoke ("colorChange", fallDelay);
	}

	void colorChange()
	{
		rend.material.color = new Color(0.5F, 0.3F, 0.1F, 0.5F);
		Invoke ("Fall", fallDelay);
	}
	
	void Fall()
	{
		rend.material.color = new Color(0.25F, 0.11F, 0F, 0.5F);
		bc2d.isTrigger = true;
		//rb2d.isKinematic = false;
	}


}
