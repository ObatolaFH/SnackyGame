using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnacks : MonoBehaviour
{
    int numToSpawn = 25;
    public float spawnOffser = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Node")
        {
            for (int i = 0; i < numToSpawn; i++)
            {
                //Clone a new node
                GameObject clone = Instantiate(gameObject, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
