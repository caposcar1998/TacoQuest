using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredAtack : MonoBehaviour
{
    // Start is called before the first frame update
    public float damageEnemy = .5f;
    public float throath;
    public float knockTime;
    void OnTriggerEnter2D(Collider2D object_punched){

       if (object_punched.tag == "Enemy"){
           object_punched.GetComponent<Enemie_stats>().TakeDamage(1f);
        Rigidbody2D enemy = object_punched.GetComponent<Rigidbody2D>();
            if (enemy != null){
                enemy.isKinematic = false;
                Vector2 difference = enemy.transform.position - transform.position;
                difference = difference.normalized * throath;
                enemy.AddForce(difference, ForceMode2D.Impulse);
                StartCoroutine(KnockCo(enemy));
            }
       }
       
    }
    private IEnumerator KnockCo(Rigidbody2D enemy){
            if(enemy != null){
                yield return new WaitForSeconds(knockTime);
                enemy.velocity = Vector2.zero;
                enemy.isKinematic = true;
            }       
        }
   
}


