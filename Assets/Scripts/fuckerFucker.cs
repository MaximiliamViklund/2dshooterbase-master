using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class fuckerFucker : MonoBehaviour{
    [SerializeField]
    float speed=0.5f;

    [SerializeField]
    GameObject explosionPrefuck;
    
    void Start(){
        Vector2 pos=new();
        pos.y=Camera.main.orthographicSize+1;
        pos.x=Random.Range(-5f,5f);//Hur använda camerasize?? (Aspect ratio)
        transform.position=pos;
    }

    // Update is called once per frame
    void Update(){
        Vector2 move=Vector2.down;

        move.x=Mathf.Sin(transform.position.y);
        transform.Translate(move*speed*Time.deltaTime);

        if(transform.position.y< -Camera.main.orthographicSize-1){
            Destroy(this.gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        Instantiate(explosionPrefuck,transform.position, Quaternion.identity);
        Destroy(this.gameObject);

        GameObject player=GameObject.FindGameObjectWithTag("Player");
        ShipController controller=player.GetComponent<ShipController>();


                /*GameObject.FindGameObjectWithTag("Player")
                    .GetComponent<ShipController>()
                    .AddPoints(1); */

        if(other.tag=="Bolt"){
            controller.AddPoints(1);
        }
    }
}