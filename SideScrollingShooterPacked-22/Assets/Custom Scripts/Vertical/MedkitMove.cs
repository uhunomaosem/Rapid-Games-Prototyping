using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitMove : MonoBehaviour
{
	public float vSpeed;
	public float maxXOffset;
	protected float origXPos;

	void Start()
	{
		origXPos = transform.position.x;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = new Vector2(origXPos + maxXOffset, transform.position.y - (vSpeed * Time.deltaTime));
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			GetComponent<HealthComponent>().getHealth(20);

		}
	}
}
