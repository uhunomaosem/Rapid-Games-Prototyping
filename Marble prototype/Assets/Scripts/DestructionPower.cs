using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionPower : MonoBehaviour
{
    void Start()
    {
        Destroy(this, 10);
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Destructibles")
        {
            Destroy(collision.gameObject);
        }
    }
}
