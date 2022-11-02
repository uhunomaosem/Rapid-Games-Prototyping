using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourDoorControl : MonoBehaviour
{
    public Texture entryTexture;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public Vector3 doorMovement;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Player")
        {
            MeshRenderer meshRenderer = other.GetComponent<MeshRenderer>();

            if (meshRenderer.materials[0].mainTexture == entryTexture)
            {
                Debug.Log("Correct");
                leftDoor.transform.position = leftDoor.transform.position + doorMovement;
                rightDoor.transform.position = rightDoor.transform.position - doorMovement;
            }
        }
    }
}
