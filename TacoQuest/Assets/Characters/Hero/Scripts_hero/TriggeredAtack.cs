using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredAtack : MonoBehaviour
{
    // Start is called before the first frame update
    public float damageHero = .5f;

    void OnTriggerEnter2D(Collider2D object_punched){

       Debug.Log(object_punched.name) ;
       
    }
}
