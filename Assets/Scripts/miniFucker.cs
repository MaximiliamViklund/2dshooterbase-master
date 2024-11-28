using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniFucker:fuckerFucker{

    override public void Update(){
            Vector2 move=Vector2.down;

        transform.Translate(move*speed*Time.deltaTime);

        if(transform.position.y< -Camera.main.orthographicSize-1){
            Destroy(this.gameObject);
        }
    }
}
