//To work in unity
using UnityEngine;
//MonoBehavior is needed in all classes
public class Hero : MonoBehaviour, Character, BasicAccion {
   
    //Constructor
    public Hero(){}

   //Getters and setters of interfaces
    string Character.name{get; set;}
    double Character.life{get; set;}
    double Character.atackPower{get; set;}
    double Character.defensePower{get; set;}

    void BasicAccion.meleeAtack(Character a){}
    void BasicAccion.rangeAtack(Character a){}
    void BasicAccion.move(Character a){}

    
    
}  