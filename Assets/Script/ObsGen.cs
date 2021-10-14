using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGen : MonoBehaviour
{
    public GameObject blocker;
    public float minX;
    public float maxX;
    public float maxY = 5.75f;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Instantiate(blocker, transform.position + new Vector3(maxX, maxY, 0), transform.rotation);
    }
}
