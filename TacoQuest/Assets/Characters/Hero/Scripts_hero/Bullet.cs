using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody2D rb;

        void Start()
    {
        
        if (Input.GetKey (KeyCode.D)) {
             rb.velocity = transform.right * speed;
         }
         if (Input.GetKey (KeyCode.A)) {
             rb.velocity = -transform.right * speed;
         } 
         if (Input.GetKey (KeyCode.W)) {
             rb.velocity = transform.up * speed;
         }
         if (Input.GetKey (KeyCode.S)) {
             rb.velocity = -transform.up * speed;                      
         }    
    
    }

    void FixedUpdate(){
        //rb.AddForce(Vector3.forward * 100);
    }

    void OnTriggerEnter2D(Collider2D object_hitted){

       Debug.Log(object_hitted.name) ;
       if (object_hitted.gameObject.CompareTag("Bullet")){
           object_hitted.GetComponent<Enemie_stats>().TakeDamage(.5f);

       }
       
    }
    // Update is called once per frame
    
}
