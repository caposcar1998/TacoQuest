using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//MonoBehavior is needed in all classes
public class Hero : MonoBehaviour{

    
    private float speed = 8.0f;

    //Constructor
    private string nombre;
    public static float vida;
    private double ataque;
    private double defensa;

    public Rigidbody2D rb; 
    public Animator player;

    public Transform shooter;
    public GameObject object_shoot;
    private bool atackMovement = false;

    private int tortilla_counter;

    private float atackTimer =0;
    private float atackCooled = 0.3f;
    public Collider2D atackTriggered;
    
    public Text tortilladata;
    public Text healthdata;
   
    void Start() {
        
        
        vida = 10f;
        rb.GetComponent<Rigidbody2D>();
        atackTriggered.enabled = false;
        
        
    }

    void Update()
    {
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h, v)*speed*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.S)){
            player.SetBool("Move_front",true);
            player.SetBool("Move_rigth", false);
            player.SetBool("Move_top",false);
            player.SetBool("Atack", false);
            player.SetBool("Move_left", false);
            rb.velocity = -transform.up * 100;
                      
        }
        if(Input.GetKeyDown(KeyCode.D )){
            player.SetBool("Move_left", true);
            player.SetBool("Move_rigth", false);
            player.SetBool("Move_top",false);
            player.SetBool("Move_front",false);
            rb.velocity = transform.right * 100;
             
        }
        if(Input.GetKeyDown(KeyCode.A )){
            player.SetBool("Move_rigth", true);
            player.SetBool("Move_left", false);
            player.SetBool("Move_top",false);
            player.SetBool("Move_front",false);
            rb.velocity = -transform.right * 100;
            
             
        }
        if(Input.GetKeyDown(KeyCode.W)){
            player.SetBool("Move_top",true);
            player.SetBool("Move_left", false);
            player.SetBool("Move_rigth", false);
            player.SetBool("Atack", false);
            player.SetBool("Move_front",false);
            rb.velocity = transform.up * 100;
            
        }


        if (Input.GetKeyDown(KeyCode.Space)) {
            print ("Access menu");
        } 
         if (Input.GetKeyDown(KeyCode.P)) {
            print ("Atack");
            player.SetBool("Atack", true);
            player.SetBool("Move_left", false);
            player.SetBool("Move_rigth", false);
            player.SetBool("Move_top",false);
            atackMovement = true;
            atackTriggered.enabled = true;
            atackTimer = atackCooled;

        }else{
            player.SetBool("Atack", false);
            
        }
        if(atackTimer > 0){
            atackTimer -= Time.deltaTime;
        }else{
            atackMovement = false;
            atackTriggered.enabled = false;
        }
         if (Input.GetKeyDown(KeyCode.O)) {
            print ("Lanzar taco");
            Shoot();
            
            
        
        }              
         if (Input.GetKeyDown(KeyCode.J)) {
            print ("Change weapon");
        }

        if (vida <=0){
            
            //Destroy (gameObject);
            print ("Morido");
            SceneManager.LoadScene(0);
        }
    }
    

    void OnTriggerEnter2D(Collider2D col){
        
        if(col.gameObject.CompareTag("Pickups")){
            col.gameObject.SetActive(false);

        if(col.gameObject.name.Equals("Coin")){
            tortilla_counter+=1;
            tortilladata.text = tortilla_counter.ToString();

            print ("A fucking coin you bastard");
        }
        if(col.gameObject.name.Equals("Papas")){
            vida+=2;
            print ("Some papitas");
        }
        if(col.gameObject.name.Equals("Boing")){
            vida+=5;
            print ("Un pinche Boing de mango perro asqueroso");
        }
        
        }

        
    }

     void Shoot (){
         Instantiate(rb, shooter.position, shooter.rotation);
         

    }

     public void TakeDamage(float damage){
        vida -= damage;
     
     }

   
    
    
}  