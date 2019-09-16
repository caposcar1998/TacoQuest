using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie_stats : MonoBehaviour
{

    public float life = 10;
    
    public void TakeDamage(float damage){
        life -= damage;

        if (life <=0){
            Die();
        }
    }

    void Die(){
        Destroy (gameObject);
    }

}
