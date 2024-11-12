using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltFucker : MonoBehaviour{
    [SerializeField]
    float speed=5;

    // Update is called once per frame
    void Update(){
        Vector2 move=Vector2.up;

        //move.x=Mathf.Sin(transform.position.y);
        transform.Translate(move*speed*Time.deltaTime);

        if(transform.position.y>Camera.main.orthographicSize+1){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Fucker"){
            Destroy(this.gameObject);
        }
    }
}
