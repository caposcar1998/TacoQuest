using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject spawnee;
    public bool stop = false;
    public float time;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemie", time, delay);
    }

    public void SpawnEnemie(){
        Instantiate(spawnee, transform.position, transform.rotation);
        if (stop){
            CancelInvoke("SpawnEnemie");
        }
    }

}
