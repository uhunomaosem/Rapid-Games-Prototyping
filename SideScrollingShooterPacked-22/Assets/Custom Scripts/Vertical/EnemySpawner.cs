using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyToSpawn;
    public float spawnRate;
    public int countToSpawn;

    private float time = 0;
    private int spawned = 0;

    public PathCreation.PathCreator followPathPrefab;
    private PathCreation.PathCreator path;

    private void Start()
    {
        path = Instantiate(followPathPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > spawnRate)
        {
            GameObject enemy = Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            //transform.Rotate(Vector3.right * -180);
            enemy.GetComponent<PathCreation.Examples.PathFollower>().speed = Random.Range(0.1f, 1.5f);
            enemy.GetComponent<PathCreation.Examples.PathFollower>().pathCreator = path;


            time = 0;
            spawned++;
            if (spawned > countToSpawn)
            {
                Destroy(gameObject);
            }
        }


    }



}
