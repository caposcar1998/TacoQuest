using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class TriggeredAtackToHero: MonoBehaviour
     {
    
    public float damageHero = .5f;
   public float throath;
    void OnTriggerEnter2D(Collider2D object_punched){

        if  (object_punched.gameObject.CompareTag ("Player")){
            object_punched.GetComponent<Hero>().TakeDamage(1f);
            Rigidbody2D hero = object_punched.GetComponent<Rigidbody2D>();
            if (hero != null){
                hero.isKinematic = false;
                Vector2 difference = hero.transform.position - transform.position;
                difference = difference.normalized * throath;
                hero.AddForce(difference, ForceMode2D.Impulse);
                hero.isKinematic = true;
                // StartCoroutine(knockCo(hero));
            }
        }    
       
    }

    //private IEnumerator KnockCo(Rigidbody2D hero){
    //    if(hero != null){
    //        yield return new WaitForSeconds(knockTime);
    //        hero.velocity = Vector2.zero;
    //        hero.isKinematic = true;
    //    }       
    //}
    }

