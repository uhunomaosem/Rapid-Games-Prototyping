using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float spawnRate;
    public int countToSpawn;

    private float time = 0;
    private int spawned = 0;




    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spawnRate)
        {
            GameObject enemy = Instantiate(enemyToSpawn, transform.position, transform.rotation);
            transform.Rotate(Vector3.right * -180);
            enemy.GetComponent<MeteorMove>().maxXOffset = Random.Range(-8f, 8f);


            time = 0;
            spawned++;
            if (spawned > countToSpawn)
            {
                Destroy(gameObject);
            }
        }
    }
}
