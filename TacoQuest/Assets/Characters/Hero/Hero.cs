
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



   
    void Start() {

    vida = 10f;
    rb = GetComponent<Rigidbody2D>();

        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h, v));

        if (Input.GetKeyDown(KeyCode.Space)) {
            print ("Access menu");
        } 
         if (Input.GetKeyDown(KeyCode.P)) {
            print ("Atack");
        } 
         if (Input.GetKeyDown(KeyCode.O)) {
            print ("Defend");
        }              
         if (Input.GetKeyDown(KeyCode.I)) {
            print ("Magic");
        }
         if (Input.GetKeyDown(KeyCode.J)) {
            print ("Change weapon");
        }

        if (vida <=0){
            
            //Destroy (gameObject);
            print ("Morido");
            SceneManager.LoadScene("Menu");
        }
    }
    

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name.Equals("Fire")){
            vida -= .5f;
            print (vida);
        }
        
    }
    
    
}  