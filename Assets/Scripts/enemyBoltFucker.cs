using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBoltFucker : MonoBehaviour{
    [SerializeField] float speed=5;

    void Start(){
        Vector2 pos=new();
        pos.y=Camera.main.orthographicSize+1;
        pos.x=Random.Range(-5f,5f);//Hur använda camerasize?? (Aspect ratio)
        transform.position=pos;
    }

    // Update is called once per frame
    void Update(){
        Vector2 move=Vector2.down;
        transform.Translate(move*speed*Time.deltaTime);

        if(transform.position.y<-Camera.main.orthographicSize-1){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            GameObject.FindGameObjectWithTag("Player").GetComponent<ShipController>().TakeHp();
            Destroy(this.gameObject);
        }
    }
}