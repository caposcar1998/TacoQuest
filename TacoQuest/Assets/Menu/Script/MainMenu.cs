using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public int numScene; 

    public void LoadScene(int numScene){
        //change to oder scene
        SceneManager.LoadScene(numScene);
    }

    public void ExitGame(){
        Debug.Log("Quiting");
        Application.Quit();
    }
}
