//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PushScript : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour
{
    [Tooltip("The force multiplier of the push-pad")]
    [Range(1f, 3f)]
    public float pushForce = 1.5f;
    private float pushforceMod = 1000f;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("PLAYER GOOOOO");
            collider.GetComponent<PlayerController>().RB.AddForce(Vector3.left * (pushForce * pushforceMod), ForceMode.Force);
        }
    }
}
