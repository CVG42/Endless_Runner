using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGenerator : MonoBehaviour
{
    public GameObject obstacle;
    private float timeSpawn;
    public float startTime;
    public float decreaseTime;
    public float minTime = .7f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(timeSpawn <=0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeSpawn = startTime;
            if(startTime > minTime)
            {
                startTime -= decreaseTime;
            }
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}
