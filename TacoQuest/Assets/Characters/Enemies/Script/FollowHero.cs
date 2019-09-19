using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowHero : MonoBehaviour
{

    public Animator enemie;
    public float speed = 5;

    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) < 6){

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            enemie.SetBool("Atack", true);    
        }  else{
            enemie.SetBool("Atack", false); 
        }
        
        
        
    }
}
