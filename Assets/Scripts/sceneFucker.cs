using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneFucker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

    }

    public void ChangeScene(int n){
        SceneManager.LoadScene(n);
    }

    public void Restart(){
        ShipController.points=0;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
