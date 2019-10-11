using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody2D rb;
    private float lifetime = 2.5f;

    public float throath;
        void Start()
    {
        Destroy(gameObject, lifetime);
        rb.velocity = transform.right * speed;
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

       if (object_hitted.gameObject.CompareTag("Enemy")){ 
           object_hitted.GetComponent<Enemie_stats>().TakeDamage(.5f);
            Destroy(gameObject);
            Rigidbody2D enemy = object_hitted.GetComponent<Rigidbody2D>();
            if (enemy != null){
                enemy.isKinematic = false;
                Vector2 difference = enemy.transform.position - transform.position;
                difference = difference.normalized * throath;
                enemy.AddForce(difference, ForceMode2D.Impulse);
                enemy.isKinematic = true;
                //StartCoroutine(knockCo(enemy));
            }
       }
       
    }
    // Update is called once per frame
    //IEnumerator KnockCo(Rigidbody2D enemy){
    //    if(enemy != null){
    //        yield return new WaitForSeconds(knockTime);
    //        enemy.velocity = Vector2.zero;
    //        enemy.isKinematic = true;
    //    }       
    //}


}
