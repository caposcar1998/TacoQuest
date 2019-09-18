using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
            rb.velocity = transform.right *speed;
    }

    void OnTriggerEnter2D(Collider2D object_hitted){

       Debug.Log(object_hitted.name) ;
       if (object_hitted.tag == "Enemy"){
           object_hitted.GetComponent<Enemie_stats>().TakeDamage(.5f);
           
       }
       
    }
    // Update is called once per frame
    
}
