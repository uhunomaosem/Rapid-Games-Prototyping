using UnityEngine;
using System.Collections;

public class RedPlagueMover : MonoBehaviour 
{
	public float vSpeed;
	public float maxXOffset;
	protected float origXPos;
	
	void Start()
	{
		origXPos = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector2(origXPos + maxXOffset * Mathf.Sin(Time.time), transform.position.y  - (vSpeed * Time.deltaTime));
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.tag == "player")
        //{
        //    destroy(other.gameobject);
        //}

        if (other.tag == "Projectile")
        {
            GetComponent<HealthComponent>().takeDamage(100);
        }

        //GetComponent<HealthComponent>().TakeDamage(20);
        //if (GetComponent<HealthComponent>().health <= 0)
        //{

        //    ScoreSystem scoresytem = FindObjectOfType<ScoreSystem>();
        //    scoresytem.AddScore(10);
        //}

    }


}
