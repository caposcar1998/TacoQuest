using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredAtack : MonoBehaviour
{
    // Start is called before the first frame update
    public float damageHero = .5f;

    void OnTriggerEnter2D(Collider2D object_punched){

       if (object_punched.tag == "Enemy"){
           object_punched.GetComponent<Enemie_stats>().TakeDamage(1f);
       }
       
    }
}
