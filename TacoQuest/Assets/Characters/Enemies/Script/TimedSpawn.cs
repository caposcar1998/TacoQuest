using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject spawnee;
    public bool stop = false;
    private bool two_EnemiesSpawned = false;
    private int enemies = 2; 
    public float time;
    public float delay;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        InvokeRepeating("SpawnEnemie", time, delay);
    }

    public void SpawnEnemie(){

        counter++;
        Instantiate(spawnee, transform.position, transform.rotation);
        if (stop || counter>=enemies){
            CancelInvoke("SpawnEnemie");
        }
        
        
        
    }

}
