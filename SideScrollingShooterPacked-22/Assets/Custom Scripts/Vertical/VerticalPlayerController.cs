using UnityEngine;
using System.Collections;

public class VerticalPlayerController : MonoBehaviour 
{
	public GameObject projectile;
	public Transform firePoint1, firePoint2;
	public float maxSpeed;
	public float moveForce;
	public float fireRate;
	
	protected float horizVelocity;
	protected float vertVelocity;
	protected Rigidbody2D myRigidbody;
	
	protected bool firing;
	protected float fireTimer;	
	
	protected VerticalPushCamera cam;


	[SerializeField] private AudioClip fireSound;
    [SerializeField] private AudioClip hurtSound;

    void Awake()
	{
		cam = Camera.main.GetComponent<VerticalPushCamera>();
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector2(transform.position.x, transform.position.y + (cam.speed * Time.deltaTime));
		
		if (firing == true)
		{
			fireTimer += Time.deltaTime;
			
			if (fireTimer >= fireRate)
			{
				firing = false;
				fireTimer = 0;	
			}	
		}
		
		if (Input.GetButton("Fire1") && firing == false)
		{
			Instantiate (projectile, firePoint1.position, transform.rotation);
			Instantiate (projectile, firePoint2.position, transform.rotation);
			firing = true;

            SoundFXManager.instance.PlaySoundFX(fireSound, firePoint1, 1f);
        }
		
		horizVelocity = Input.GetAxis("Horizontal");
		vertVelocity = Input.GetAxis("Vertical");
	}
	
	void FixedUpdate()
	{
		myRigidbody.AddForce(horizVelocity * Vector2.right * moveForce);

		myRigidbody.AddForce(vertVelocity * Vector2.up * moveForce);

		if (Mathf.Abs(myRigidbody.velocity.sqrMagnitude) > maxSpeed * maxSpeed)
		{
			myRigidbody.velocity = Vector2.ClampMagnitude(myRigidbody.velocity, maxSpeed);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy")
        {
            if (gameObject.GetComponent<HealthComponent>() != null)
            {
				SoundFXManager.instance.PlaySoundFX(hurtSound, transform, 1f);
                gameObject.GetComponent<HealthComponent>().takeDamage(20);
            }
		}

		if (other.tag == "Obstacle")
		{
            if (gameObject.GetComponent<HealthComponent>() != null)
            {
				gameObject.GetComponent<HealthComponent>().takeDamage(100);
            }
		}

		if (other.tag == "Medic")
        {
			if (gameObject.GetComponent<HealthComponent>() != null)
            {
				gameObject.GetComponent<HealthComponent>().getHealth(100);
			}

		}

	}



}
