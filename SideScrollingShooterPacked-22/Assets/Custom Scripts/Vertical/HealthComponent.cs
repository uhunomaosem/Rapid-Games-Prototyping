using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthComponent : MonoBehaviour
{
    public static Action onPlayerDeath;

    public float health;
    const float maxHealth = 100;
    public Image healthBar;
    public bool hasHealthBar;

    [SerializeField] AudioClip deathSound;

    private void Update()
    {
        if (hasHealthBar)
        {
            healthBar.fillAmount = health / 100;
        }
    }

    public void takeDamage(float damage)
    {
        health -= damage;
        Debug.Log("YES 20!!!");
        if (health <= 0)
        {
            if (gameObject != null)
            {
                health = 0;
                if (tag == "Player")
                {
                    SoundFXManager.instance.PlaySoundFX(deathSound, transform, 1f);
                    onPlayerDeath?.Invoke();

                }
            }
            if (tag == "Enemy")
            {
                Destroy(gameObject);

                if (GetComponent<HealthComponent>().health <= 0)
                {

                    ScoreSystem scoresytem = FindObjectOfType<ScoreSystem>();
                    scoresytem.AddScore(10);
                }
            }

        }
    }

    public void getHealth(float heal)
    {
        health += heal;
        if (health > maxHealth)
        {
            health = 100;
        }
    }


}
