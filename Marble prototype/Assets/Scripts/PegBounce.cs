using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegBounce : MonoBehaviour
{
    public float bounceScale = 1000f;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("YES");
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            Vector3 playerPos = playerController.transform.position;
            Vector3 obstPos = transform.position;
            Vector3 towardPlayer = playerPos - obstPos;
            towardPlayer.Normalize();
            playerController.RB.AddForce(towardPlayer * bounceScale, ForceMode.Force);
            

        }
    }
}
