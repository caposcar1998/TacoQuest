
using UnityEngine;
using UnityEngine.SceneManagement;
//MonoBehavior is needed in all classes
public class Hero : MonoBehaviour{

    
    private float speed;
    //Constructor
    private string nombre;
    public static float vida;
    private double ataque;
    private double defensa;

    Rigidbody2D rb;
    public Animator player;

    public Transform shooter;
    public GameObject object_shoot;
    private bool atackMovement = false;

    private float atackTimer =0;
    private float atackCooled = 0.3f;
    public Collider2D atackTriggered;
    
   
    void Start() {

    vida = 10f;
    rb = GetComponent<Rigidbody2D>();
    atackTriggered.enabled = false;
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h, v));

        if(Input.GetKeyDown(KeyCode.S)){
            player.SetBool("Move_front",true);
            player.SetBool("Move_rigth", false);
            player.SetBool("Move_top",false);
            player.SetBool("Atack", false);
            player.SetBool("Move_left", false);
        }

        if(Input.GetKeyDown(KeyCode.D )){
            player.SetBool("Move_left", true);
            player.SetBool("Move_rigth", false);
            player.SetBool("Move_top",false);
            player.SetBool("Move_front",false);
        }
        if(Input.GetKeyDown(KeyCode.A )){
            player.SetBool("Move_rigth", true);
            player.SetBool("Move_left", false);
            player.SetBool("Move_top",false);
            player.SetBool("Move_front",false);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            player.SetBool("Move_top",true);
            player.SetBool("Move_left", false);
            player.SetBool("Move_rigth", false);
            player.SetBool("Atack", false);
            player.SetBool("Move_front",false);
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
        if(col.gameObject.name.Equals("Fire")){
            vida -= .5f;
            print (vida);
        }

        if (col.gameObject.name.Equals("potion")){
            vida += .5f;
            print (vida);
        }
        
    }

    void Shoot (){
        Instantiate(object_shoot, shooter.position, shooter.rotation);
    }
    
    
}  