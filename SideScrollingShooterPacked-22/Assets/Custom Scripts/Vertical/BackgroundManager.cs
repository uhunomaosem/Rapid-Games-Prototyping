using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{

    public List<SpriteRenderer> children;
    private Vector3 distance;

    public EnemySpawner enemySpawner;
    public GameObject enemyToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        distance = children[1].transform.position - children[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.y > children[1].transform.position.y)
        {
            MoveListOrder();
        }
    }


    void MoveListOrder()
    {
        SpriteRenderer copy = children[0];
        children.RemoveAt(0);
        children.Insert(children.Count, copy);
        children[children.Count - 1].transform.position = children[0].transform.position + distance;
    }


    void CreateSpawner()
    {
        EnemySpawner spawner = Instantiate(enemySpawner, children[children.Count - 1].transform.position, children[children.Count - 1].transform.rotation);
        spawner.countToSpawn = Random.Range(1, 10);
        spawner.
    }



}
