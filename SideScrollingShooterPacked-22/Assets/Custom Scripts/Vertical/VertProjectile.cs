﻿using UnityEngine;
using System.Collections;

public class VertProjectile : MonoBehaviour 
{
	public float speed;
	
	void Update () 
	{
		transform.position = new Vector2(transform.position.x, transform.position.y + (speed * Time.deltaTime));
	}
	
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy")
		{
			Debug.Log("ENEMY TAKEN DAMAGE");

            if (other.GetComponent<HealthComponent>() != null)
            {
				other.GetComponent<HealthComponent>().takeDamage(20);
            }
		}
	}
}
