using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthComponent : MonoBehaviour
{
    public static Action onPlayerDeath;

    public float health;
    public Image healthBar;
    public bool hasHealthBar;


    private void Update()
    {
        if (hasHealthBar)
        {
            healthBar.fillAmount = health / 100;
        }
    }

    public void TakeDamage(float damage)
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
                    onPlayerDeath?.Invoke();

                }
                Destroy(gameObject);
            }

        }
    }



}
