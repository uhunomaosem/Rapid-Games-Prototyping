using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionPower : MonoBehaviour
{
    void Start()
    {
        Destroy(this, 30);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Destructible")
        {
            PlayerController playerController = GetComponent<PlayerController>();
            playerController.Score = playerController.Score + 1000;
            Destroy(collision.gameObject);
        }
    }

}
