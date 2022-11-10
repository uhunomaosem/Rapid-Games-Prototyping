using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusforPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Destructible")
        {

        }
    }
}
